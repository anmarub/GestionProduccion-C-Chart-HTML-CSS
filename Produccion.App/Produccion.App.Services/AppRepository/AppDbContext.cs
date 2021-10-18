using Microsoft.EntityFrameworkCore;
using Produccion.App.Domain;

namespace Produccion.App.Services.AppRepository
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductionOrder> ProductionOrder { get; set; }
        public DbSet<PurchanseOrder> PurchanseOrder { get; set; }
    }
}