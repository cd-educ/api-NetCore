using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{

    [Route("/api")]
    public class ApiController : Controller
    {
        [Route("ping")]
        public string Ping()
        {
            return "Pong";
        }

        [Route("check")]
        [HttpPost]
        public IActionResult checkUser([FromBody] dynamic body)
        {

            dynamic json = JsonConvert.DeserializeObject<dynamic>(body.ToString());

            Console.WriteLine(json.user);
            Console.WriteLine(json.pwd);

            return Ok(new { valid = true});

        }

    }
}
