using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryProductionOrder : IRepositoryProductionOrder
    {
        //Defino atributo
        private readonly AppContext _appContext;
        
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryProductionOrder(AppContext appContext)
        {
            _appContext = appContext;
        }

        ProductionOrder IRepositoryProductionOrder.AddProductionOrder(ProductionOrder ProductionOrders)
        {
            var NewProductionOrders = _appContext.ProductionOrder.Add(ProductionOrders);
            _appContext.SaveChanges();
            return NewProductionOrders.Entity;
        }

        IEnumerable<ProductionOrder> IRepositoryProductionOrder.GetAllProductionOrder()
        {
            return _appContext.ProductionOrder;
        }

        ProductionOrder IRepositoryProductionOrder.GetProductionOrder(int idOrder)
        {
            return null;
        }

        ProductionOrder IRepositoryProductionOrder.UpdateProductionOrder(ProductionOrder ProductionOrders)
        {
            var SearchProductionOrders = _appContext.ProductionOrder.FirstOrDefault(i => i.id == ProductionOrders.id);
            if(SearchProductionOrders != null)
            {
                ProductionOrders.id = SearchProductionOrders.id;
                ProductionOrders.code_order = SearchProductionOrders.code_order;
                ProductionOrders.date_delivery = SearchProductionOrders.date_delivery;
                ProductionOrders.mod = SearchProductionOrders.mod;
                ProductionOrders.id_status_op = SearchProductionOrders.id_status_op;
            }
            return SearchProductionOrders;
        }

        void IRepositoryProductionOrder.DeleteProductionOrder(int idOrder)
        {
            
        }
    }
}