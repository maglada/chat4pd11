// Сервіс для обробки повідомлень
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

