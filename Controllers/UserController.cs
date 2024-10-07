using Microsoft.AspNetCore.Mvc;

// Контролер для управління користувачами
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    // Метод для отримання інформації про користувача
    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        // Логіка для отримання інформації про користувача
        return Ok(); // Повертаємо статус 200
    }
}

