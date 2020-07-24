using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSLogistic.Service.Bill_Shipper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSLogistic.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Bill_ShipperController : ControllerBase
    {
        private readonly IShipperService _shipperService;

        public Bill_ShipperController(IShipperService shipperService)
        {
            _shipperService = shipperService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _shipperService.GetDataBillShipper();
            return Ok(result);
        }
    }
}
