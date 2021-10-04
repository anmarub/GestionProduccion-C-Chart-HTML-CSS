using System;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain.Entities;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryStatusPurchanseOrder
    {
         StatusPurchanseOrder AddStatusPurchanseOrder(StatusPurchanseOrder StatusPurchanseOrder);
         IEnumerable<StatusPurchanseOrder> GetAllStatusPurchseOrder();
         StatusPurchanseOrder GetStatusPurchseOrder(int IdStatus);
         StatusPurchanseOrder UpdateStatusPurchseOrder(StatusPurchanseOrder StatusPurchanseOrder);
         void DeleteStatusPurchseOrder(int IdStatus);
    }
}