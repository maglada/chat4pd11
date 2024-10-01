var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Enable serving static files
app.UseDefaultFiles();  // Looks for index.html automatically
app.UseStaticFiles();   // Serves static files from wwwroot

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();

