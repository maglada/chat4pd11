// Сервіс для управління контактами
public class ContactService : IContactService
{
    public void AddContact(Contact contact)
    {
        // Логіка для додавання контакту
    }

    public IEnumerable<Contact> GetAllContacts()
    {
        // Логіка для отримання всіх контактів
        return new List<Contact>(); // Повертаємо порожній список
    }
}

