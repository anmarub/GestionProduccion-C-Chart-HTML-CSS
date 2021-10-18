using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Produccion.App.Domain;

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
            var NewStatusOP = _appContext.StatusPurchanseOrder.Add(StatusOP);
            _appContext.SaveChanges();
            return NewStatusOP.Entity;
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
            var SearchStatusOP = _appContext.StatusPurchanseOrder.FirstOrDefault(i => i.id == StatusOP.id);
            if(SearchStatusOP != null)
            {
                StatusOP.id = SearchStatusOP.id;
                StatusOP.codeStatus = SearchStatusOP.codeStatus;
                StatusOP.nameStatus = SearchStatusOP.nameStatus;
            }
            return SearchStatusOP;
        }

        void IRepositoryStatusPurchanseOrder.DeleteStatusPurchseOrder(int idStatusOP)
        {
            
        }
    }
}