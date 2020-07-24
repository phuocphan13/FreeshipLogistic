using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSLogistic.Service.Bill_Shipper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSLogistic.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperService _shipperService;

        public ShipperController(IShipperService shipperService)
        {
            _shipperService = shipperService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _shipperService.GetDataShipper();
            return Ok(result);
        }
    }
}
