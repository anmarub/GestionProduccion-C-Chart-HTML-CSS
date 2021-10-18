using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Produccion.App.Domain;

namespace Produccion.App.Persistence.AppRepository
{
    public interface IRepositoryCustomer
    {
        //Firma para los metodos o clases definidas en capa Dominio.
        Customer AddCustomer(Customer Customer);
        IEnumerable<Customer> GetAllCustomers (string? nombre);
        Customer GetCustomer(int? IdCustomer);
        Customer UpdateCustomer(Customer Customer);
        void DeleteCustomer(int IdCustomer);
    }
}