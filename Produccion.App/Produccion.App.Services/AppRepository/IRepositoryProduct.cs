using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Produccion.App.Domain;

namespace Produccion.App.Services.AppRepository
{
    public interface IRepositoryProduct
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProduct(int IdProduct);
        Task<Product> AddProduct(Product Product);
        Task<Product> UpdateProduct(Product Product);
        Task<Product> DeleteProduct(int IdProduct);
    }
}