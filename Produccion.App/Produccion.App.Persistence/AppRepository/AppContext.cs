using Microsoft.EntityFrameworkCore;

namespace Produccion.App.Persistence.AppRepository
{
    public class AppContext : DbContext
    {
        //public DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =HospiEncasatData");
               //optionsBuilder.UseMySql("server=localhost;database=library;user=mysqlschema;password=mypassword");
            }
        }
    }
}