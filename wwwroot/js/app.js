// Основний скрипт для клієнтської частини чату

document.addEventListener("DOMContentLoaded", function () {
    const messageInput = document.getElementById("messageInput"); // Поле для введення повідомлення
    const sendButton = document.getElementById("sendButton"); // Кнопка для надсилання повідомлення
    const messagesContainer = document.getElementById("messagesContainer"); // Контейнер для повідомлень

    // Обробка натискання на кнопку "Надіслати"
    sendButton.addEventListener("click", async function () {
        const messageContent = messageInput.value; // Отримання вмісту повідомлення
        const userId = 1; // ID користувача (тут може бути динамічний ID)

        // Виклик функції для надсилання повідомлення
        await sendMessage(messageContent, userId);

        messageInput.value = ""; // Очищення поля вводу
    });

    // Функція для надсилання повідомлення
    async function sendMessage(content, userId) {
        const response = await fetch("/api/message", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({ content, userId })
        });

        if (response.ok) {
            const message = await response.json();
            addMessageToChat(message); // Додаємо повідомлення до чату
        } else {
            console.error("Не вдалося надіслати повідомлення."); // Виводимо помилку
        }
    }

    // Функція для додавання повідомлення до чату
    function addMessageToChat(message) {
        const messageElement = document.createElement("div");
        messageElement.className = "message"; // Додаємо клас
        messageElement.textContent = message.content; // Встановлюємо текст повідомлення
        messagesContainer.appendChild(messageElement); // Додаємо елемент до контейнера
    }
});

