using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testApi.Models;
using testApi.Services;

namespace testApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;


        public AuthController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;

        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login([FromBody] LoginDto loginDto)
        {
            var user = await _userService.Users
                .SingleOrDefaultAsync(x => x.Username == loginDto.Username);

            if (user == null)
            {
                return BadRequest("Invalid username");
            }

            bool result = await _userService.CheckPasswordSignInAsync(user, loginDto.Password);

            if (!result == true)
            {
                return BadRequest("Invalid password");
            }

            return new UserDto
            {
                Username = user.Username,
                Token = _authService.GenerateJwtToken(user.Username)
            };
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            var existingUser = _authService.GetUserByUsername(registerDto.Username);

            if (existingUser != null)
            {
                return BadRequest("Username is already taken");
            }

            var user = await _authService.RegisterAsync(registerDto.Username, registerDto.Password);

            return Ok(user);
        }


        [Authorize]
        [HttpGet("me")]
        public IActionResult GetCurrentUser()
        {
            var username = User.Identity.Name;
            var user = _authService.GetUserByUsername(username);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

    }

}
