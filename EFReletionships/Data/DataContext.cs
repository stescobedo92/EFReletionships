using EFReletionships.Models;
using Microsoft.EntityFrameworkCore;

namespace EFReletionships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        DbSet<User> Users { get; set; }
        DbSet<Character> Character { get; set; }
    }
}
