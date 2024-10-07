using System;
using System.Net.Http;
using System.Threading.Tasks;

// Клас для клієнта чату
public class ChatClient
{
    private readonly HttpClient _httpClient;

    public ChatClient(HttpClient httpClient)
    {
        _httpClient = httpClient; // Ініціалізація HTTP-клієнта
    }

    // Метод для надсилання повідомлення
    public async Task SendMessageAsync(string message)
    {
        var content = new StringContent(message); // Створюємо контент повідомлення
        var response = await _httpClient.PostAsync("api/message", content); // Надсилаємо POST запит

        response.EnsureSuccessStatusCode(); // Перевірка статусу відповіді
    }
}

