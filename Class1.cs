using Microsoft.EntityFrameworkCore;
using GameLibrary;
namespace GameDatabase
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-2;Initial Catalog=GameDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");
            }
        }
    }
}