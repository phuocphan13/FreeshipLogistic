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
        public async Task<IActionResult> Get()
        {
            var bills = await _billService.Get();
            return Ok(bills);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var bills = await _billService.GetById(id);
            return Ok(bills);
        }

        [HttpGet("SearchByCustomerId/{customerId}")]
        public async Task<IActionResult> SearchByCustomerId(int customerId)
        {
            var bills = await _billService.SearchByCustomerId(customerId);
            return Ok(bills);
        }

        [HttpGet("SearchByCustomerName/{customerName}")]
        public async Task<IActionResult> SearchByCustomerName(string customerName)
        {
            var bills = await _billService.SearchByCustomerName(customerName);
            return Ok(bills);
        }

        [HttpGet("SearchByShipperId/{shipperId}")]
        public async Task<IActionResult> SearchByShipperId(int shipperId)
        {
            var bills = await _billService.SearchByShipperId(shipperId);
            return Ok(bills);
        }

        [HttpGet("SearchByShipperName/{shipperName}")]
        public async Task<IActionResult> SearchByShipperName(string shipperName)
        {
            var bills = await _billService.SearchByShipperName(shipperName);
            return Ok(bills);
        }

        // api/bill/SearchByDate/2020-07-01
        [HttpGet("SearchByDate/{searchDate}")]
        public async Task<IActionResult> SearchByDate(string searchDate)
        {
            var bills = await _billService.SearchByDate(DateTime.Parse(searchDate));
            return Ok(bills);
        }


        [HttpGet("SearchByDistrict/{districtId}")]
        public async Task<IActionResult> SearchByDistrict(District districtId)
        {
            var bills = await _billService.SearchByDistrict(districtId);
            return Ok(bills);
        }
    }
}
