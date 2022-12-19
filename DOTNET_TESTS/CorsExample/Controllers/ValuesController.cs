using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CorsExample.Controlllers
{
    [Route("api/[controller]")]
    [EnableCors("AwesomePolicy2")]
    public class ValuesController : Controller
    {
        [EnableCors("AnotherAwesomePolicy")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }

        [DisableCors]
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }
    }
}