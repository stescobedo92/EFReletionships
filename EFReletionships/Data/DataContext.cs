using EFReletionships.Models;
using Microsoft.EntityFrameworkCore;

namespace EFReletionships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Character> Character { get; set; }
    }
}
