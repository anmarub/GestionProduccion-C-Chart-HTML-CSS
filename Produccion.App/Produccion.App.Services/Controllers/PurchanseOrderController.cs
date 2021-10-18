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
    public class PurchanseOrderController : ControllerBase
    {
        private readonly RepositoryPurchanseOrder _repositoryPurchanseOrder;

        public PurchanseOrderController(RepositoryPurchanseOrder repositoryPurchanseOrder)
        {
            _repositoryPurchanseOrder = repositoryPurchanseOrder;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllPurchanseOrders()
        {
            return Ok(await _repositoryPurchanseOrder.GetAllPurchanseOrders());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetPurchanseOrder(int id)
        {
            return Ok(await _repositoryPurchanseOrder.GetPurchanseOrder(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddPurchanseOrder(PurchanseOrder OrderOC)
        {
            return Ok(await _repositoryPurchanseOrder.AddPurchanseOrder(OrderOC));
        }

        [HttpPut]
        public async Task<ActionResult> UpdatePurchanseOrder(PurchanseOrder OrderOC)
        {
            return Ok(await _repositoryPurchanseOrder.UpdatePurchanseOrder(OrderOC));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePurchanseOrder(int id)
        {
            return Ok(await _repositoryPurchanseOrder.DeletePurchanseOrder(id));
        }
    }
}