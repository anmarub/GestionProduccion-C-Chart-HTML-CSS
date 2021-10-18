using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using Produccion.App.Domain;

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
            var NewOrderStatus = _appContext.StatusProductionOrder.Add(OrderStatus);
            _appContext.SaveChanges();
            return NewOrderStatus.Entity;
        }
        IEnumerable<StatusProductionOrder> IRepositoryStatusProductionOrder.GetAllStatusProduction()
        {
            return _appContext.StatusProductionOrder;
        }

        StatusProductionOrder IRepositoryStatusProductionOrder.GetStatusProduction(int IdStatusOP)
        {
            return _appContext.StatusProductionOrder.FirstOrDefault(i => i.id == IdStatusOP);
        }

        StatusProductionOrder IRepositoryStatusProductionOrder.UpdateStatusProduction(StatusProductionOrder OrderStatus)
        {
            var SearchOrderStatus = _appContext.StatusProductionOrder.FirstOrDefault(i => i.id == OrderStatus.id);
            if(SearchOrderStatus != null)
            {
                OrderStatus.id = SearchOrderStatus.id;
                OrderStatus.code_status_op = SearchOrderStatus.code_status_op;
                OrderStatus.name = SearchOrderStatus.name;

            }
            return SearchOrderStatus;
        }

        void IRepositoryStatusProductionOrder.DeleteStatusProduction(int IdStatusOP)
        {
            
        }
    }
}