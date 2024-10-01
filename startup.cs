public void ConfigureServices(IServiceCollection services)
{
    services.AddHttpClient<MyHttpClient>();
    services.AddControllers();
}

