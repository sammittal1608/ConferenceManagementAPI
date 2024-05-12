using ConferenceManegement.Models;
using ConferenceMeeting.Services.Interfaces;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceManagementAPI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User model)
        {
            try
            {
                var addedUser = await _authService.AddUserAsync(model);
                return Ok(new { Message = "User registered successfully", User = addedUser });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = "An error occurred while registering user", Message = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User model)
        {
            try
            {
                var user = await _authService.AddUserAsync(model);
                return Ok(new { Message = "User Login successfully" });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = "An error occurred while logging in", Message = ex.Message });
            }
        }
    }
}
