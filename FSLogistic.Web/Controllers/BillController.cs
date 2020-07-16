using System;
using System.Threading.Tasks;
using FSLogistic.Service.Bill;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FSLogistic.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }


        [HttpGet("GetAll")]
        //[HttpGet]
        public async Task<IActionResult> Get()
        {
            var bills = await _billService.Get();
            return Ok(bills);
        }
        // api/bill/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var bills = await _billService.GetById(id);
            return Ok(bills);
        }

        // api/bill/SearchByCustomerId/1
        [HttpGet("SearchByCustomerId/{customerId}")]
        public async Task<IActionResult> SearchByCustomerId(int customerId)
        {
            var bills = await _billService.SearchByCustomerId(customerId);
            return Ok(bills);
        }

        // api/bill/SearchByShipperId/1
        [HttpGet("SearchByShipperId/{shipperId}")]
        public async Task<IActionResult> SearchByShipperId(int shipperId)
        {
            var bills = await _billService.SearchByShipperId(shipperId);
            return Ok(bills);
        }

        // api/bill/SearchByDate/2020-07-01
        [HttpGet("SearchByDate/{searchDate}")]
        public async Task<IActionResult> SearchByDate(string searchDate)
        {
            var bills = await _billService.SearchByDate(DateTime.Parse(searchDate));
            return Ok(bills);
        }

        // api/bill/SearchByDistrict/1
        [HttpGet("SearchByDistrict/{district}")]
        public async Task<IActionResult> SearchByDistrict(District district)
        {
            var bills = await _billService.SearchByDistrict(district);
            return Ok(bills);
        }
    }
}
