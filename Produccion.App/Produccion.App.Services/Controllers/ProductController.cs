using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Produccion.App.Services.AppRepository;
using Produccion.App.Domain;

namespace Produccion.App.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryProduct _repositoryProduct;

        public ProductController(IRepositoryProduct repositoryProduct)
        {
            _repositoryProduct = repositoryProduct;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            return Ok(await _repositoryProduct.GetAllProducts());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            return Ok(await _repositoryProduct.GetProduct(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(Product Product)
        {
            return Ok(await _repositoryProduct.AddProduct(Product));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProduct(Product Product)
        {
            return Ok(await _repositoryProduct.UpdateProduct(Product));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            return Ok(await _repositoryProduct.DeleteProduct(id));
        }
    }
}