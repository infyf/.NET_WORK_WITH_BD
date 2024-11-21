using Microsoft.EntityFrameworkCore;
using lr12_bd.Models;

namespace lr12_bd.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public static void SeedDatabase(AppDbContext context)
        {
            // Очищення таблиці (видаляємо всі записи, якщо такі є)
            if (context.Companies.Any())
            {
                context.Companies.RemoveRange(context.Companies);
                context.SaveChanges();
            }

            // Додавання нових записів
            context.Companies.AddRange(
                new Company { Name = "Space X", Address = "Address 44", NumberOfEmployees = 2250 },
                new Company { Name = "Apple", Address = "Address B11", NumberOfEmployees = 113200 },
                new Company { Name = "Space Y", Address = "Address111", NumberOfEmployees = 23300 },
                new Company { Name = "Samsung", Address = "Address 11D", NumberOfEmployees = 36300 },
                new Company { Name = "Xiaomi", Address = "Address E1f", NumberOfEmployees = 156540 }
            );

            context.SaveChanges();
        }
    }
}