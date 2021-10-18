using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Produccion.App.Domain;

namespace Produccion.App.Services.AppRepository
{
    public class RepositoryPurchanseOrder : IRepositoryPurchanseOrder
    {
        //Defino atributo
        private readonly AppDbContext _appContext;
        //Defino Constructor y agrego el atributo para marcarlo como obligatorio
        public RepositoryPurchanseOrder(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public async Task<PurchanseOrder> AddPurchanseOrder(PurchanseOrder OrdeOc)
        {
            try{
            var NewOrdeOc = await _appContext.PurchanseOrder.AddAsync(OrdeOc);
            await _appContext.SaveChangesAsync();
            return NewOrdeOc.Entity;
            }catch{
                throw;
            }

        }
        public async Task<IEnumerable<PurchanseOrder>> GetAllPurchanseOrders()
        {
            return await _appContext.PurchanseOrder.ToListAsync();
        }
        public async Task<PurchanseOrder> GetPurchanseOrder(int IdOrderOc)
        {
            var SearchOC = await _appContext.PurchanseOrder.FirstOrDefaultAsync(c => c.id == IdOrderOc);
            return SearchOC;
        }

        public async Task<PurchanseOrder> UpdatePurchanseOrder(PurchanseOrder OrdeOc)
        {
            var SearchOrdeOc = await _appContext.PurchanseOrder.FirstOrDefaultAsync(i => i.id == OrdeOc.id);
            if(SearchOrdeOc != null)
            {
                OrdeOc.id = SearchOrdeOc.id;
                OrdeOc.num_oc = SearchOrdeOc.num_oc;
                OrdeOc.id_customer = SearchOrdeOc.id_customer;
                OrdeOc.id_status_oc = SearchOrdeOc.id_status_oc;
                OrdeOc.date_delivery = SearchOrdeOc.date_delivery;
                
                await _appContext.SaveChangesAsync();
            }
            return SearchOrdeOc;
        }

        public async Task<PurchanseOrder> DeletePurchanseOrder(int IdOrderOc)
        {
            var SearchOP = await _appContext.PurchanseOrder.FirstOrDefaultAsync(c => c.id == IdOrderOc);
            if (SearchOP != null)
            {
                _appContext.PurchanseOrder.Remove(SearchOP);
                await _appContext.SaveChangesAsync();
                return SearchOP;
            }
            return null;   
        }
    }
}