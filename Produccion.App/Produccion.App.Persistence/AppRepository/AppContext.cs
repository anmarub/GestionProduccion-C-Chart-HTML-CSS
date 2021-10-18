using Microsoft.EntityFrameworkCore;
using Produccion.App.Domain;

namespace Produccion.App.Persistence.AppRepository
{
    public class AppContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
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
                optionsBuilder.UseSqlServer("Server=localhost; user id=sa; password=12345678; Initial Catalog=produccion;"); 
            }
        }
    }
}