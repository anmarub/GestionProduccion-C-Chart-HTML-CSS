using Microsoft.EntityFrameworkCore;
using Produccion.App.Domain.Entities;

namespace Produccion.App.Persistence.AppRepository
{
    public class AppContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<OcDetailsFkProduct> OcDetailsFkProduct { get; set; }
        public DbSet<OpDetailsFkProduct> OpDetailsFkProduct { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductionOrder> ProductionOrder { get; set; }
        public DbSet<PurchanseOrder> PurchanseOrder { get; set; }
        public DbSet<StatusProductionOrder> StatusProductionOrder { get; set; }
        public DbSet<StatusPurchanseOrder> StatusPurchanseOrder { get; set; }
        public DbSet<TypeDocument> TypeDocument { get; set; }
        public DbSet<TypeProduct> TypeProduct { get; set; }
        public DbSet<User> User { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =produccion");
               //optionsBuilder.UseMySql("server=localhost;database=library;user=mysqlschema;password=mypassword");
            }
        }
    }
}