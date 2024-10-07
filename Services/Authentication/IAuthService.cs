// Інтерфейс для сервісу аутентифікації
public interface IAuthService
{
    string Login(string username, string password); // Метод для входу
    void Register(string username, string password); // Метод для реєстрації
}

