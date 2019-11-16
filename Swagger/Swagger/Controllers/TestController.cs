using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Swagger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "lab";
        }

        [HttpPost]
        public TestResponse Post(TestRequest request)
        {
            return new TestResponse { FullName = request.Name + " " + request.SurName };
        }
    }
}
