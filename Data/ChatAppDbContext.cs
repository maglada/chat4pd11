using Microsoft.EntityFrameworkCore;

// Контекст бази даних для чату
public class ChatAppDbContext : DbContext
{
    public ChatAppDbContext(DbContextOptions<ChatAppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; } // Сет користувачів
    public DbSet<Message> Messages { get; set; } // Сет повідомлень
    public DbSet<Contact> Contacts { get; set; } // Сет контактів
}

