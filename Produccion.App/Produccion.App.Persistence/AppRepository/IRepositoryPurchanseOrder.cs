using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Produccion.App.Domain;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryPurchanseOrder
    {
         PurchanseOrder AddPurchanseOrder(PurchanseOrder PurchanseOrder);
         IEnumerable<PurchanseOrder> GetAllPurchanseOrder();
         PurchanseOrder GetPurchanseOrder(int IdPurchanseOrder);
         PurchanseOrder UpdatePurchanseOrder(PurchanseOrder PurchanseOrder);
         void DeletePurchanseOrder(int IdPurchanseOrder);
    }
}