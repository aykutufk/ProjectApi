using Microsoft.AspNetCore.Mvc;
using ProjectApi.Data;
using ProjectApi.Models;

namespace ProjectApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly DataContext _context;

        public CommentsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{postId}")]
        public ActionResult GetComments(int postId)
        {
            var comments = _context.Comment.Where(c => c.Post.PostId == postId).ToList();
            return Ok(comments);
        }

        [HttpPost("{postId}")]
        public ActionResult CreateComment(int postId, [FromBody] CommentModel comment)
        {
            var post = _context.Posts.FirstOrDefault(p => p.PostId == postId);

            if (post == null)
            {
                return NotFound();
            }

            comment.UserName = "Anonymous"; // veya auth işlemleri ekleyerek alabilirsiniz
            comment.Email = "anonymous@example.com"; // veya auth işlemleri ekleyerek alabilirsiniz
            comment.Content = "Some comment content"; // request body'den alabilirsiniz

            post.Comments.Add(comment);
            _context.SaveChanges();

            return Ok(comment);
        }
    }
}
