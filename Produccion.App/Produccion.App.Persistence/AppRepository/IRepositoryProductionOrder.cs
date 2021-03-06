using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryProductionOrder
    {
         ProductionOrder AddProductionOrder(ProductionOrder ProductionOrder);
         IEnumerable<ProductionOrder> GetAllProductionOrder();
         ProductionOrder GetProductionOrder(int IdOrderProduction);
         ProductionOrder UpdateProductionOrder(ProductionOrder ProductionOrder);
         void DeleteProductionOrder(int IdOrderProduction);
    }
}