using System;
using System.Security.Cryptography;
using System.Text;

// Клас для хешування паролів
namespace YourNamespace.Helpers
{
    public class PasswordHasher
    {
        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create()) // логіка для хешування
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}


