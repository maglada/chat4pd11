// Сервіс для аутентифікації
public class AuthService : IAuthService
{
    public string Login(string username, string password)
    {
        // Логіка для входу
        return "token"; // Повертаємо токен
    }

    public void Register(string username, string password)
    {
        // Логіка для реєстрації
    }
}

