using chat4pd11.Models.DTOs;

public interface IAuthService
{
    Task<AuthResult> RegisterAsync(UserRegistrationDto registrationDto);
    Task<AuthResult> LoginAsync(UserLoginDto loginDto);
}

