using System.Collections.Generic;
using System.Linq;
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
            var AddingCustomer = _appContext.Customer.Add(customer);
            _appContext.SaveChanges();
            return AddingCustomer.Entity;
        }

        IEnumerable<Customer> IRepositoryCustomer.GetAllCustomer()
        {
            return _appContext.Customer;
        }

        Customer IRepositoryCustomer.GetCustomer(int IdCustomer)
        {
            return _appContext.Customer.FirstOrDefault(c => c.Id == IdCustomer); 
        }

        Customer IRepositoryCustomer.UpdateCustomer(Customer customer)
        {
            var SearchCustomer = _appContext.Customer.FirstOrDefault(c => c.Id == customer.Id);
            if (SearchCustomer != null)
            {
                SearchCustomer.identification           = customer.identification;
                SearchCustomer.name                     = customer.name;
                SearchCustomer.email                    = customer.email;
                SearchCustomer.address                  = customer.address;
                SearchCustomer.id_type_identification   = customer.id_type_identification;
                _appContext.SaveChanges();
            }
            return SearchCustomer;
        }

        void IRepositoryCustomer.DeleteCustomer(int idCustomer)
        {
            var SearchCustomer = _appContext.Customer.FirstOrDefault(c => c.Id == idCustomer);
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