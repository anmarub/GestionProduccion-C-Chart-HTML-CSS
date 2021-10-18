using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Produccion.App.Domain;

namespace Produccion.App.Services.AppRepository
{
    public interface IRepositoryCustomer
    {
        //Firma para los metodos o clases definidas en capa Dominio.
        Task<IEnumerable<Customer>> GetAllCustomers ();
        Task<Customer> GetCustomer(int IdCustomer);
        Task<Customer> AddCustomer(Customer Customer);
        Task<Customer> UpdateCustomer(Customer Customer);
        Task<Customer> DeleteCustomer(int IdCustomer);
    }
}