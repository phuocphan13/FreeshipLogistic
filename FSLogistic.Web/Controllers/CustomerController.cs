using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSLogistic.Model.Customer;
using FSLogistic.Service.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSLogistic.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _customerService.GetDataCustomer();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateModel data)
        {
            var result = await _customerService.CreateCustomer(data);
            return Ok(result);
        }
    }
}
