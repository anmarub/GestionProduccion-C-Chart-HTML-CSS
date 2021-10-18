using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Produccion.App.Domain;

namespace Produccion.App.Services.AppRepository
{
    public class RepositoryCustomer : IRepositoryCustomer
    {
        // Instanciamos el objecto de la clase AppContext
        private readonly AppDbContext _appContext;

        public RepositoryCustomer(AppDbContext appContext)    
        {
            _appContext = appContext;
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            try{
            
                var AddingCustomer = await _appContext.Customer.AddAsync(customer);
                await _appContext.SaveChangesAsync();
                return AddingCustomer.Entity;

            }catch{
            
                throw;
            }
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _appContext.Customer.ToListAsync();            
        }

        public async Task<Customer> GetCustomer(int IdCustomer)
        {
            var SearchCustomer = await _appContext.Customer.FirstOrDefaultAsync(c => c.id == IdCustomer);
            return SearchCustomer;
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            var SearchCustomer = await _appContext.Customer.FirstOrDefaultAsync(c => c.id == customer.id);
            
            if (SearchCustomer != null)
            {
                SearchCustomer.identification = customer.identification;
                SearchCustomer.name = customer.name;
                SearchCustomer.email = customer.email;
                SearchCustomer.address = customer.address;
                SearchCustomer.id_type_identification = customer.id_type_identification;
            
                await _appContext.SaveChangesAsync();
            }
            return SearchCustomer;
        }

        public async Task<Customer> DeleteCustomer(int idCustomer)
        {
            var SearchCustomer = await _appContext.Customer.FirstOrDefaultAsync(c => c.id == idCustomer);
            if (SearchCustomer != null)
            {
                _appContext.Customer.Remove(SearchCustomer);
                await _appContext.SaveChangesAsync();
                return SearchCustomer;
            }
            return null;
        }

    }
}