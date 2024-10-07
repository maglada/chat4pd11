// Інтерфейс для роботи з повідомленнями
using System.Collections.Generic;

public interface IMessageRepository
{
    void SendMessage(Message message); // Метод для надсилання повідомлення
    IEnumerable<Message> GetAllMessages(); // Метод для отримання всіх повідомлень
}

