using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Produccion.App.Domain;

namespace Produccion.App.Services.AppRepository
{
    public interface IRepositoryProductionOrder
    {
        Task<IEnumerable<ProductionOrder>> GetAllProductionOrders();
        Task<ProductionOrder> GetProductionOrder(int IdProductionOrder);
        Task<ProductionOrder> AddProductionOrder(ProductionOrder ProductionOrder);
        Task<ProductionOrder> UpdateProductionOrder(ProductionOrder ProductionOrder);
        Task<ProductionOrder> DeleteProductionOrder(int IdProductionOrder);
    }
}