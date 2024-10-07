// Інтерфейс для сервісу обробки повідомлень
public interface IMessageService
{
    void SendMessage(Message message); // Метод для надсилання повідомлення
    IEnumerable<Message> GetAllMessages(); // Метод для отримання всіх повідомлень
}

