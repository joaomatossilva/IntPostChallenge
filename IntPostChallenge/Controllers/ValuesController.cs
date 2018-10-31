using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntPostChallenge.Model;
using Microsoft.AspNetCore.Mvc;

namespace IntPostChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public RequestModel Post([FromBody] RequestModel value)
        {
            return value;
        }
    }
}
