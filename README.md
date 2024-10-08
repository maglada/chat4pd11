# Chat Application

Цей проект є веб-додатком для чату, розробленим за допомогою ASP.NET Core. Додаток дозволяє користувачам надсилати та отримувати повідомлення в реальному часі.

## Вимоги

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Сумісний веб-браузер (Chrome, Firefox, Edge, тощо)

## Установка

1. **Клонування репозиторію**:
   `git clone https://github.com/yourusername/chat4pd11.git
   cd chat4pd11`
   
## Встановлення залежностей: Переконайтеся, що у вас встановлений .NET SDK, а потім виконайте:



`dotnet restore`




## Налаштування бази даних: Виконайте міграції для створення бази даних:


  `dotnet ef database update`

## Запуск проекту:




    `dotnet run`

   Веб-додаток буде доступний за адресою https://localhost:5001.

## Використання

   Відкрийте http://localhost:5001 у вашому веб-браузері.
   Введіть ваше повідомлення в текстове поле та натисніть кнопку "Надіслати", щоб надіслати повідомлення.
   Повідомлення будуть відображатися у контейнері для повідомлень.

## Технології

   ASP.NET Core: Фреймворк для розробки веб-додатків.
   Entity Framework Core: ORM для роботи з базою даних.
   JavaScript: Для обробки взаємодії на клієнтській стороні.
   CSS: Для оформлення інтерфейсу.

