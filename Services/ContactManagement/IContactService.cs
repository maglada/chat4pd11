// Інтерфейс для сервісу управління контактами
public interface IContactService
{
    void AddContact(Contact contact); // Метод для додавання контакту
    IEnumerable<Contact> GetAllContacts(); // Метод для отримання всіх контактів
}

