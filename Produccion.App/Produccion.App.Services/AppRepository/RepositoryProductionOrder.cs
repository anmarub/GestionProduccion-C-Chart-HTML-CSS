using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Produccion.App.Domain;

namespace Produccion.App.Services.AppRepository
{
    public class RepositoryProductionOrder : IRepositoryProductionOrder
    {
        //Defino atributo
        private readonly AppDbContext _appContext;
        
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryProductionOrder(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<ProductionOrder> AddProductionOrder(ProductionOrder ProductionOrders)
        {
            try{
                var NewProductionOrders = await _appContext.ProductionOrder.AddAsync(ProductionOrders);
                await _appContext.SaveChangesAsync();
                return NewProductionOrders.Entity;
            }catch{
                throw;
            }

        }

        public async Task<IEnumerable<ProductionOrder>> GetAllProductionOrders()
        {
            return await _appContext.ProductionOrder.ToListAsync();
        }

        public async Task<ProductionOrder> GetProductionOrder(int idOrder)
        {
            var SearchOP = await _appContext.ProductionOrder.FirstOrDefaultAsync(c => c.id == idOrder);
            return SearchOP;
        }

        public async Task<ProductionOrder> UpdateProductionOrder(ProductionOrder ProductionOrders)
        {
            var SearchProductionOrders = await _appContext.ProductionOrder.FirstOrDefaultAsync(i => i.id == ProductionOrders.id);
            if(SearchProductionOrders != null)
            {
                ProductionOrders.id = SearchProductionOrders.id;
                ProductionOrders.code_order = SearchProductionOrders.code_order;
                ProductionOrders.date_delivery = SearchProductionOrders.date_delivery;
                ProductionOrders.mod = SearchProductionOrders.mod;
                ProductionOrders.id_status_op = SearchProductionOrders.id_status_op;

                await _appContext.SaveChangesAsync();
            }
            return SearchProductionOrders;
        }

        public async Task<ProductionOrder> DeleteProductionOrder(int idOrder)
        {
            var SearchOP = await _appContext.ProductionOrder.FirstOrDefaultAsync(c => c.id == idOrder);
            if (SearchOP != null)
            {
                _appContext.ProductionOrder.Remove(SearchOP);
                await _appContext.SaveChangesAsync();
                return SearchOP;
            }
            return null;
        }
    }
}