using Microsoft.AspNetCore.Mvc;

// Контролер для обробки повідомлень
[ApiController]
[Route("api/[controller]")]
public class MessageController : ControllerBase
{
    // Метод для отримання повідомлень
    [HttpGet]
    public IActionResult GetMessages()
    {
        // Логіка для отримання повідомлень
        return Ok(); // Повертаємо статус 200
    }
}

