// Інтерфейс для роботи з повідомленнями
public interface IMessageRepository
{
    void SendMessage(Message message); // Метод для надсилання повідомлення
    IEnumerable<Message> GetAllMessages(); // Метод для отримання всіх повідомлень
}

