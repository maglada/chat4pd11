using System;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

// Проміжне програмне забезпечення для обробки винятків
public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next; // Ініціалізація делегата
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context); // Продовжуємо обробку запиту
        }
        catch (Exception ex)
        {
            // Логіка для обробки винятків
            context.Response.StatusCode = StatusCodes.Status500InternalServerError; // Встановлюємо статус 500
            await context.Response.WriteAsync("Виникла помилка."); // Повертаємо повідомлення про помилку
        }
    }
}
