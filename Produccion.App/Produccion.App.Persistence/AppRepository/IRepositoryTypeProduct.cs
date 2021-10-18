using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryTypeProduct
    {
         TypeProduct AddTypeProduct(TypeProduct typeProduct);
         IEnumerable<TypeProduct> GetAllTypeProduct();
         TypeProduct GetTypeProduct(int idType);
         TypeProduct UpdateTypeProduct(TypeProduct typeProduct);
         void DeleteTypeProduct(int idType);
    }
}