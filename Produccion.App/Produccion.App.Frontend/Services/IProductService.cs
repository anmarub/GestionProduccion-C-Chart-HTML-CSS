using System.Collections.Generic;
using System.Threading.Tasks;

using Produccion.App.Domain;

namespace Produccion.App.Frontend.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProduct(int IdProduct);
        Task DeleteProduct(int IdProduct);
        Task AddProduct(Product customer);
        Task UpdateProduct(Product customer);   
    }
}