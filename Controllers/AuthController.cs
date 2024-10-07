using Microsoft.AspNetCore.Mvc;

// Контролер для аутентифікації
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    // Метод для реєстрації користувача
    [HttpPost("register")]
    public IActionResult Register([FromBody] UserRegistrationDto userDto)
    {
        // Логіка для реєстрації користувача
        return Ok(); // Повертаємо статус 200
    }

    // Метод для входу користувача
    [HttpPost("login")]
    public IActionResult Login([FromBody] UserLoginDto userDto)
    {
        // Логіка для входу користувача
        return Ok(); // Повертаємо статус 200
    }
}

