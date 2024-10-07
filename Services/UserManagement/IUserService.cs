// Інтерфейс для сервісу управління користувачами
public interface IUserService
{
    User GetUserById(int id); // Метод для отримання користувача за ID
    void RegisterUser(User user); // Метод для реєстрації користувача
}

