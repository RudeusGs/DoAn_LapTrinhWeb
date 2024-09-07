using DragonAcc.Models;
using Microsoft.EntityFrameworkCore;

namespace DragonAcc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Product> Accounts { get; set; }
        public DbSet<Product> HistoryOfGuests { get; set; }
        public DbSet<Product> HistoryOfSellers { get; set; }
        public DbSet<Product> Revenues { get; set; }
        public DbSet<Product> Services { get; set; }
        public DbSet<Product> ServiceDetails { get; set; }
    }
}
