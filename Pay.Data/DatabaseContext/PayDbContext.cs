using Microsoft.EntityFrameworkCore;
using Pay.Data.Models;

namespace Pay.Data.DatabaseContext
{
    internal class PayDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"data source=DESKTOP-VD50B2F;initial catalog=DbPay;MultipleActiveResultSets=True;Integrated Security = True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<BankCard> BankCards { get; set; }
    }
}
