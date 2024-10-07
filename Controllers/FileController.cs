using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// Контролер для роботи з файлами
[ApiController]
[Route("api/[controller]")]
public class FileController : ControllerBase
{
    // Метод для завантаження файлу
    [HttpPost("upload")]
    public IActionResult UploadFile(IFormFile file)
    {
        // Логіка для завантаження файлу
        return Ok(); // Повертаємо статус 200
    }
}

