using Microsoft.AspNetCore.Mvc;
using ProjectApi.Data;
using ProjectApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace ProjectApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _context;

        public AuthController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] AdminModel login)
        {
            var user = _context.Admin.FirstOrDefault(u => u.Username == login.Username && u.PasswordHash == login.PasswordHash);

            if (user == null)
            {
                return Unauthorized();
            }

            return Ok(user);
        }
    }
}
