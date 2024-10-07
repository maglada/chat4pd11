// Інтерфейс для роботи з контактами
using System.Collections.Generic;

public interface IContactRepository
{
    void AddContact(Contact contact); // Метод для додавання контакту
    IEnumerable<Contact> GetAllContacts(); // Метод для отримання всіх контактів
}

