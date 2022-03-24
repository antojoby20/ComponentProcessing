using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComponentProcessingMS.Models;
using ComponentProcessingMS.Services;
using ComponentProcessingMS.Repositorys;


namespace ComponentProcessingMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComponentProcessingController : ControllerBase
    {
        private IComponentServ _componentServ;

        public ComponentProcessingController(IComponentServ componentServ)
        {
            _componentServ = componentServ;
        }
        [HttpPost]
        public IActionResult GetProcess([FromBody] ProcessRequest req)
        {
           // ProcessRequest req = RequestDataHelper.requestObject;
            return Ok(_componentServ.GetProcessResponse(req));
        }
        [Route("PaymentsData")]
        [HttpGet]
        public IActionResult PaymentsData()
        {
            return Ok(RequestDataHelper.responseObj);
        }
        
        [Route("CompleteProcessing")]
        [HttpPost]
         public IActionResult CompletProcessing()
        {
            return Ok(_componentServ.CompleteProcess());
        }



    }
}
