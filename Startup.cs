using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers(); // Додаємо контролери
        // Додаткові сервіси, такі як DBContext, репозиторії, сервіси
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage(); // Використовуємо сторінку помилок для розробки
        }
        else
        {
            app.UseExceptionHandler("/Home/Error"); // Використовуємо обробку помилок
            app.UseHsts(); // Використовуємо HSTS
        }

        app.UseHttpsRedirection(); // Перенаправляємо на HTTPS
        app.UseRouting(); // Додаємо маршрутизацію

        app.UseAuthorization(); // Додаємо авторизацію

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers(); // Вказуємо маршрути для контролерів
        });
    }
}

