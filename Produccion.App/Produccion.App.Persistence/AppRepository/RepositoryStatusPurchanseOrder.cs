using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryStatusPurchanseOrder : IRepositoryStatusPurchanseOrder
    {
        //Defino atributo
        private readonly AppContext _appContext;
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryStatusPurchanseOrder(AppContext appContext)
        {
            _appContext = appContext;
        }

        StatusPurchanseOrder IRepositoryStatusPurchanseOrder.AddStatusPurchanseOrder(StatusPurchanseOrder StatusOP)
        {
            return null;
        }
        IEnumerable<StatusPurchanseOrder> IRepositoryStatusPurchanseOrder.GetAllStatusPurchseOrder()
        {
            return _appContext.StatusPurchanseOrder;
        }

        StatusPurchanseOrder IRepositoryStatusPurchanseOrder.GetStatusPurchseOrder(int idStatusOP)
        {
            return _appContext.StatusPurchanseOrder.FirstOrDefault(i => i.id == idStatusOP);
        }

        StatusPurchanseOrder IRepositoryStatusPurchanseOrder.UpdateStatusPurchseOrder(StatusPurchanseOrder StatusOP)
        {
            return null;
        }

        void IRepositoryStatusPurchanseOrder.DeleteStatusPurchseOrder(int idStatusOP)
        {
            
        }
    }
}