using EFReletionships.Models;
using Microsoft.EntityFrameworkCore;

namespace EFReletionships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
               
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .HasOne(a => a.Weapon)
                .WithOne(b => b.Character)
                .HasForeignKey<Weapon>(b => b.CharacterId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
    }
}
