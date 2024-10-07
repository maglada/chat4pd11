using Microsoft.AspNetCore.Mvc;

// Контролер для управління контактами
[ApiController]
[Route("api/[controller]")]
public class ContactController : ControllerBase
{
    // Метод для додавання контакту
    [HttpPost("add")]
    public IActionResult AddContact([FromBody] ContactDto contactDto)
    {
        // Логіка для додавання контакту
        return Ok(); // Повертаємо статус 200
    }

    // Метод для отримання контактів
    [HttpGet]
    public IActionResult GetContacts()
    {
        // Логіка для отримання списку контактів
        return Ok(); // Повертаємо статус 200
    }
}

