using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace Produccion.App.Persistence.AppRepository
{
    public class AppContext : Dbcontext
    {
        public DbSet<Customer> Customer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                //optionsBuilder.UseMySql("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = produccion");
                optionsBuilder.UseMySql("server=localhost;database=library;user=mysqlschema;password=mypassword");
            }else{
                console.WriteLine("Error al conectar con la base datos");
            }
        }
        
    }
}