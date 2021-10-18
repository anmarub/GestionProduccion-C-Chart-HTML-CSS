using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

using Produccion.App.Domain;

namespace Produccion.App.Frontend.Services
{
    public class ProductService : IProductService
    {
       private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _httpClient.GetJsonAsync<Product[]>("api/product");
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _httpClient.GetJsonAsync<Product>($"api/product/{id}");
        }

        public async Task DeleteProduct(int id)
        {
            await _httpClient.DeleteAsync($"api/product/{id}");
        }

        public async Task AddProduct(Product product)
        {
            await _httpClient.PostJsonAsync($"api/product",product);
        }

         public async Task UpdateProduct(Product product)
        {
            await _httpClient.PutJsonAsync($"api/product",product);
        } 
    }
}