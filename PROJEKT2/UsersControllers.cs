using Microsoft.AspNetCore.Mvc;

namespace MyDotnetApp.Controllers
{
    [ApiController]
    [Route("[controller]")] // kjo do të bëjë endpoint /users
    public class UsersController : ControllerBase
    {
        // GET /users
        [HttpGet]
        public IActionResult GetUsers()
        {
            // shembull përdoruesish të thjeshtë
            var users = new[]
            {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" },
                new { Id = 3, Name = "Charlie" }
            };

            return Ok(users);
        }

        // GET /users/{id}
        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = new { Id = id, Name = $"User{id}" };
            return Ok(user);
        }
    }
}
