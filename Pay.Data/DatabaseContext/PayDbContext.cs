using Microsoft.EntityFrameworkCore;


namespace Pay.Data.DatabaseContext
{
    internal class PayDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString: @"data source=DESKTOP-VD50B2F;initial catalog=DbPay;MultipleActiveResultSets=True;Integrated Security = True;");


        }
    }
}
