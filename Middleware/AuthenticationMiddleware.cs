using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

// Проміжне програмне забезпечення для аутентифікації
public class AuthenticationMiddleware
{
    private readonly RequestDelegate _next;

    public AuthenticationMiddleware(RequestDelegate next)
    {
        _next = next; // Ініціалізація делегата
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Логіка для аутентифікації
        await _next(context); // Продовжуємо обробку запиту
    }
}

