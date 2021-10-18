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
    public class ProductionOrderController : ControllerBase
    {
        private readonly IRepositoryProductionOrder _repositoryProductionOrder;

        public ProductionOrderController(IRepositoryProductionOrder repositoryProductionOrder)
        {
            _repositoryProductionOrder = repositoryProductionOrder;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllProductionOrders()
        {
            return Ok(await _repositoryProductionOrder.GetAllProductionOrders());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProductionOrder(int id)
        {
            return Ok(await _repositoryProductionOrder.GetProductionOrder(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddProductionOrder(ProductionOrder ProductionOrder)
        {
            return Ok(await _repositoryProductionOrder.AddProductionOrder(ProductionOrder));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateProductionOrder(ProductionOrder ProductionOrder)
        {
            return Ok(await _repositoryProductionOrder.UpdateProductionOrder(ProductionOrder));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProductionOrder(int id)
        {
            return Ok(await _repositoryProductionOrder.DeleteProductionOrder(id));
        }
    }
}