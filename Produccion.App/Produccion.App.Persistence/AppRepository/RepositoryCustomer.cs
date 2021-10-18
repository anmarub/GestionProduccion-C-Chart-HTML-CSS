using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Produccion.App.Domain;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryCustomer : IRepositoryCustomer
    {
        // Instanciamos el objecto de la clase AppContext
        private readonly AppContext _appContext;

        public IEnumerable<Customer> customers {get; set;}

        public RepositoryCustomer(AppContext appContext)    
        {
            _appContext = appContext;
        }

        Customer IRepositoryCustomer.AddCustomer(Customer customer)
        {
            try{
            
                var AddingCustomer = _appContext.Customers.Add(customer);
                _appContext.SaveChanges();
                return AddingCustomer.Entity;

            }catch{
            
                throw;
            }
        }

        IEnumerable<Customer> IRepositoryCustomer.GetAllCustomers(string? nombre)
        {
            if(nombre != null)
            {
                customers = _appContext.Customers.Where(p => p.name.Contains(nombre));
            }else
                customers = _appContext.Customers;

            return customers;            
        }

        Customer IRepositoryCustomer.GetCustomer(int? IdCustomer)
        {
            return _appContext.Customers.FirstOrDefault(c => c.id == IdCustomer); 
        }

        Customer IRepositoryCustomer.UpdateCustomer(Customer customer)
        {
            var SearchCustomer = _appContext.Customers.FirstOrDefault(c => c.id == customer.id);
            if (SearchCustomer != null)
            {
                SearchCustomer.identification = customer.identification;
                SearchCustomer.name = customer.name;
                SearchCustomer.email = customer.email;
                SearchCustomer.address = customer.address;
                SearchCustomer.id_type_identification = customer.id_type_identification;
                _appContext.SaveChanges();
            }
            return SearchCustomer;
        }

        void IRepositoryCustomer.DeleteCustomer(int idCustomer)
        {
            var SearchCustomer = _appContext.Customers.FirstOrDefault(c => c.id == idCustomer);
            if (SearchCustomer == null)
            {
                return;
            }else{
                _appContext.Customers.Remove(SearchCustomer);
                _appContext.SaveChanges();
            }
        }

    }
}