using System;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryProduct
    {
     Product AddProduct(Product Product);
     IEnumerable<Product> GetAllProduct();
     Product GetProduct(int IdProduct);
     Product UpdateProduct(Product Product);
     void DeleteProduct(int IdProduct);
    }
}