// Сервіс для обробки повідомлень
using System.Collections.Generic;

public class MessageService : IMessageService
{
    public void SendMessage(Message message)
    {
        // Логіка для надсилання повідомлення
    }

    public IEnumerable<Message> GetAllMessages()
    {
        // Логіка для отримання всіх повідомлень
        return new List<Message>(); // Повертаємо порожній список
    }
}

