using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryPurchanseOrder : IRepositoryPurchanseOrder
    {
        //Defino atributo
        private readonly AppContext _appContext;
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryPurchanseOrder(AppContext appContext)
        {
            _appContext = appContext;
        }

        PurchanseOrder IRepositoryPurchanseOrder.AddPurchanseOrder(PurchanseOrder OrdeOc)
        {
            return null;
        }
        IEnumerable<PurchanseOrder> IRepositoryPurchanseOrder.GetAllPurchanseOrder()
        {
            return null;
        }
        PurchanseOrder IRepositoryPurchanseOrder.GetPurchanseOrder(int IdOrderOc)
        {
            return null;
        }

        PurchanseOrder IRepositoryPurchanseOrder.UpdatePurchanseOrder(PurchanseOrder OrdeOc)
        {
            return null;
        }

        void IRepositoryPurchanseOrder.DeletePurchanseOrder(int IdOrderOc)
        {
            
        }
    }
}