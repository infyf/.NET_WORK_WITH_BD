using Microsoft.EntityFrameworkCore;
using lr12_bd.Models;

namespace lr12_bd.Data
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=UserDatabase;Trusted_Connection=True;");
            }
        }
    }
}
