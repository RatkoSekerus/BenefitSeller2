using BenefitSeller.API.Contracts.ManagerInterfaces;
using BenefitSeller.API.Models.DomainModels;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace BenefitSeller.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IAuthService _authService;

        public AuthController(IConfiguration configuration, IAuthService authService)
        {
            _configuration = configuration;
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AccountCredentials request)
        {
            if (await _authService.UserExists(request.Email))
            {
                return BadRequest("User already exists.");
            }

            await _authService.RegisterUser(request.Email, request.Password);
            return Ok("Registration successful.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AccountCredentials request)
        {
            var user = await _authService.ValidateUser(request.Email, request.Password);
            if (user == null)
            {
                return Unauthorized("Invalid username or password.");
            }

            var token = _authService.GenerateJwtToken(user.UserName, user.Role);
            return Ok(new { Token = token });
        }
    }

}
