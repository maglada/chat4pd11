using System.Security.Cryptography;
using System.Text;

// Клас для хешування паролів
public static class PasswordHasher
{
    public static string HashPassword(string password)
    {
        // Логіка для хешування пароля
        return Convert.ToBase64String(new SHA256Managed().ComputeHash(Encoding.UTF8.GetBytes(password)));
    }
}

