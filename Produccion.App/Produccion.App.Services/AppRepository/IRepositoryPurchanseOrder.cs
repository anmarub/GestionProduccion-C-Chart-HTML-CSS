using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Produccion.App.Domain;

namespace Produccion.App.Services.AppRepository
{
    public interface IRepositoryPurchanseOrder
    {
        Task<IEnumerable<PurchanseOrder>> GetAllPurchanseOrders();
        Task<PurchanseOrder> GetPurchanseOrder(int IdPurchanseOrder);
        Task<PurchanseOrder> AddPurchanseOrder(PurchanseOrder PurchanseOrder);
        Task<PurchanseOrder> UpdatePurchanseOrder(PurchanseOrder PurchanseOrder);
        Task<PurchanseOrder> DeletePurchanseOrder(int IdPurchanseOrder);
    }
}