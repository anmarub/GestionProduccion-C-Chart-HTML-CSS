using System.Collections.Generic;
using System.Linq;
using System;
using Produccion.App.Domain.Entities;
using Produccion.App.Persistence.AppRepository;

namespace Produccion.App.Persistence.AppRepository
{
    public class RepositoryCustomer : IRepositoryCustomer
    {
        // Instanciamos el objecto de la clase AppContext
        private readonly AppContext _appContext;

        public RepositoryCustomer(AppContext appContext)
        {
            _appContext = appContext;
        }

        Customer IRepositoryCustomer.AddCustomer(Customer customer)
        {
            try{
            
            var AddingCustomer = _appContext.Customer.Add(customer);
            _appContext.SaveChanges();
            return AddingCustomer.Entity;

            }catch(ArgumentNullException e){
            
                Console.WriteLine("Exception Message: " + e.Message);
                return null;
            }
        }

        IEnumerable<Customer> IRepositoryCustomer.GetAllCustomer()
        {
            try{

                return _appContext.Customer;

            }catch(ArgumentNullException e){

                Console.WriteLine("Exception Message: " + e.Message);
                return null;
            }
            
        }

        Customer IRepositoryCustomer.GetCustomer(int IdCustomer)
        {
            return _appContext.Customer.FirstOrDefault(c => c.id == IdCustomer); 
        }

        Customer IRepositoryCustomer.UpdateCustomer(Customer customer)
        {
            var SearchCustomer = _appContext.Customer.FirstOrDefault(c => c.id == customer.id);
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
            var SearchCustomer = _appContext.Customer.FirstOrDefault(c => c.id == idCustomer);
            if (SearchCustomer == null)
            {
                return;
            }else{
                _appContext.Customer.Remove(SearchCustomer);
                _appContext.SaveChanges();
            }
        }

    }
}