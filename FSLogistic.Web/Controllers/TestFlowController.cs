using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSLogistic.Domain.Models;
using FSLogistic.Model.TestFlowModel;
using FSLogistic.Service.TestFlow;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FSLogistic.Web.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class TestFlowController : ControllerBase
    {
        private readonly ITestFlowService _testFlowService;

        public TestFlowController(ITestFlowService testFlowService)
        {
            _testFlowService = testFlowService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _testFlowService.Get();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(Summary testFlowCreate)
        {
            var result = _testFlowService.Create(testFlowCreate);
            return Ok(result);
        }
    }
}
