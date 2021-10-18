using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

using Produccion.App.Domain;

namespace Produccion.App.Frontend.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _httpClient;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _httpClient.GetJsonAsync<Customer[]>("api/customer");
        }

        public async Task<Customer> GetCustomer(int id)
        {
            return await _httpClient.GetJsonAsync<Customer>($"api/customer/{id}");
        }

        public async Task DeleteCustomer(int id)
        {
            await _httpClient.DeleteAsync($"api/customer/{id}");
        }

        public async Task AddCustomer(Customer customer)
        {
            await _httpClient.PostJsonAsync($"api/customer",customer);
        }

         public async Task UpdateCustomer(Customer customer)
        {
            await _httpClient.PutJsonAsync($"api/customer",customer);
        }   
    }
}