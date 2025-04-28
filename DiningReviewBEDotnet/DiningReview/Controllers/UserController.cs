using Microsoft.AspNetCore.Mvc;
using DiningReview.Models;
using DiningReview.Repositories;

namespace DiningReview.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            if (_userRepository.ExistsByDisplayName(user.DisplayName))
            {
                return Conflict("Display name already exists.");
            }

            var savedUser = _userRepository.Save(user);
            return CreatedAtAction(nameof(GetUser), new { displayName = savedUser.DisplayName }, savedUser);
        }

        [HttpGet("{displayName}")]
        public IActionResult GetUser(string displayName)
        {
            var user = _userRepository.FindByDisplayName(displayName);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            return Ok(user);
        }
    }
}