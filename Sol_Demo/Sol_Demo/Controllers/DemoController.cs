using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Models;

namespace Sol_Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpPost("badrequest")]
        public IActionResult BadRequestDemo()
        {
            return base.BadRequest(new ErrorModel()
            {
                StatusCode = 400,
                Message = "Bad Request"
            });
        }

        [HttpPost("onexception")]
        public IActionResult OnExceptionDemo()
        {
            throw new Exception("Exception");
        }
    }
}