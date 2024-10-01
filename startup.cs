using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        // Enable serving static files
        app.UseDefaultFiles(); // This looks for default files like index.html automatically
        app.UseStaticFiles();  // This serves the static files from wwwroot

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}

