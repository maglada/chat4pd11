// Сервіс для управління користувачами
public class UserService : IUserService
{
    public User GetUserById(int id)
    {
        // Логіка для отримання користувача за ID
        return new User(); // Повертаємо нового користувача
    }

    public void RegisterUser(User user)
    {
        // Логіка для реєстрації користувача
    }
}

