using Microsoft.AspNetCore.Mvc;
using ProjectApi.Data;
using ProjectApi.Models;

namespace ProjectApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly DataContext _context;

        public PostsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetPosts()
        {
            var posts = _context.Posts.Include(p => p.Admin).Include(p => p.Category).ToList();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public ActionResult GetPost(int id)
        {
            var post = _context.Posts.Include(p => p.Admin).Include(p => p.Category).FirstOrDefault(p => p.PostId == id);

            if (post == null)
            {
                return NotFound();
            }

            return Ok(post);
        }

        [HttpPost]
        public ActionResult CreatePost([FromBody] PostModel post)
        {
            if (ModelState.IsValid)
            {
                post.DatePublished = DateTime.Now;
                _context.Posts.Add(post);
                _context.SaveChanges();
                return Ok(post);
            }

            return BadRequest(ModelState);
        }
    }
}
