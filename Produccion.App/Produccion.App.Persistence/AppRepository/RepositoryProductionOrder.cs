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
            return null;
        }

        IEnumerable<ProductionOrder> IRepositoryProductionOrder.GetAllProductionOrder()
        {
            return null;
        }

        ProductionOrder IRepositoryProductionOrder.GetProductionOrder(int idOrder)
        {
            return null;
        }

        ProductionOrder IRepositoryProductionOrder.UpdateProductionOrder(ProductionOrder ProductionOrders)
        {
            return null;
        }

        void IRepositoryProductionOrder.DeleteProductionOrder(int idOrder)
        {
            
        }
    }
}