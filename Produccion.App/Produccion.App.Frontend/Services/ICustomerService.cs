using System.Collections.Generic;
using System.Threading.Tasks;

using Produccion.App.Domain;


namespace Produccion.App.Frontend.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomer(int IdCustomer);
        Task DeleteCustomer(int IdCustomer);
        Task AddCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);         
    }
}