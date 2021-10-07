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
            var NewOrdeOc = _appContext.PurchanseOrder.Add(OrdeOc);
            _appContext.SaveChanges();
            return NewOrdeOc.Entity;

        }
        IEnumerable<PurchanseOrder> IRepositoryPurchanseOrder.GetAllPurchanseOrder()
        {
            return _appContext.PurchanseOrder;
        }
        PurchanseOrder IRepositoryPurchanseOrder.GetPurchanseOrder(int IdOrderOc)
        {
            return _appContext.PurchanseOrder.FirstOrDefault(i => i.id == IdOrderOc);
        }

        PurchanseOrder IRepositoryPurchanseOrder.UpdatePurchanseOrder(PurchanseOrder OrdeOc)
        {
            var SearchOrdeOc = _appContext.PurchanseOrder.FirstOrDefault(i => i.id == OrdeOc.id);
            if(SearchOrdeOc != null)
            {
                OrdeOc.id = SearchOrdeOc.id;
                OrdeOc.num_oc = SearchOrdeOc.num_oc;
                OrdeOc.id_customer = SearchOrdeOc.id_customer;
                OrdeOc.id_status_oc = SearchOrdeOc.id_status_oc;
                OrdeOc.date_delivery = SearchOrdeOc.date_delivery;
            }
            return SearchOrdeOc;
        }

        void IRepositoryPurchanseOrder.DeletePurchanseOrder(int IdOrderOc)
        {
            
        }
    }
}