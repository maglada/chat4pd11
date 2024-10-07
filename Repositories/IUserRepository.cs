// Інтерфейс для роботи з користувачами
public interface IUserRepository
{
    User GetUserByUsername(string username); // Метод для отримання користувача за ім'ям
    void RegisterUser(User user); // Метод для реєстрації користувача
}

