using LibraryManagement_BackendAPI.Dtos;
using LibraryManagement_BackendAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement_BackendAPI.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _service;

        public AuthController(IUserService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserDto dto)
        {
            await _service.RegisterAsync(dto);
            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUserDto dto)
        {
            var token = await _service.LoginAsync(dto);
            if (token == null) return Unauthorized("Invalid credentials");

            return Ok(new { token });
        }
    }
}
