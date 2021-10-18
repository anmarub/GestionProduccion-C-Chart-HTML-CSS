using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Produccion.App.Services.AppRepository;
using Produccion.App.Domain;

namespace Produccion.App.Persistence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepositoryCustomer _repositoryCustomer;

        public CustomerController(IRepositoryCustomer repositoryCustomer)
        {
            _repositoryCustomer = repositoryCustomer;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllCustomers()
        {
            return Ok(await _repositoryCustomer.GetAllCustomers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetCustomer(int id)
        {
            return Ok(await _repositoryCustomer.GetCustomer(id));
        }

        [HttpPost]
        public async Task<ActionResult> AddCustomer(Customer customer)
        {
            return Ok(await _repositoryCustomer.AddCustomer(customer));
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCustomer(Customer customer)
        {
            return Ok(await _repositoryCustomer.UpdateCustomer(customer));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            return Ok(await _repositoryCustomer.DeleteCustomer(id));
        }
    }
}