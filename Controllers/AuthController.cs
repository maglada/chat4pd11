using Microsoft.AspNetCore.Mvc;
using chat4pd11.Models.DTOs;
using chat4pd11.Services.Authentication;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRegistrationDto registrationDto)
    {
        var result = await _authService.RegisterAsync(registrationDto);
        if (!result.Success)
            return BadRequest(result.Message);
        return Ok(new { Token = result.Token });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLoginDto loginDto)
    {
        var result = await _authService.LoginAsync(loginDto);
        if (!result.Success)
            return Unauthorized(result.Message);
        return Ok(new { Token = result.Token });
    }
}

