using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryStatusProductionOrder : IRepositoryStatusProductionOrder
    {
        //Defino atributo
        private readonly AppContext _appContext;
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryStatusProductionOrder(AppContext appContext)
        {
            _appContext = appContext;
        }

        StatusProductionOrder IRepositoryStatusProductionOrder.AddStatusProductionOrder(StatusProductionOrder OrderStatus)
        {
            return null;
        }
        IEnumerable<StatusProductionOrder> IRepositoryStatusProductionOrder.GetAllStatusProduction()
        {
            return null;
        }

        StatusProductionOrder IRepositoryStatusProductionOrder.GetStatusProduction(int IdStatusOP)
        {
            return null;
        }

        StatusProductionOrder IRepositoryStatusProductionOrder.UpdateStatusProduction(StatusProductionOrder OrderStatus)
        {
            return null;
        }

        void IRepositoryStatusProductionOrder.DeleteStatusProduction(int IdStatusOP)
        {
            
        }
    }
}