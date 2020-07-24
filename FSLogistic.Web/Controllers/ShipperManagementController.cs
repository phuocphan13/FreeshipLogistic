﻿using System.Threading.Tasks;
using FSLogistic.Service.ShipperManagement;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace FSLogistic.Web.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ShipperManagementController : ControllerBase
    {   
            private readonly IShipperManagementService _shipperManagementService;
        public ShipperManagementController(IShipperManagementService shipperManagementService)
        {
            _shipperManagementService = shipperManagementService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            var result = await _shipperManagementService.GetListAccount();
            return Ok(result);
        }
    }
}
