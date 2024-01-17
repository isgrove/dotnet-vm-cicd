using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace ExampleApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VersionController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            // string version = string.Empty;
            // string filePath = "./version.txt";

            // using StreamReader reader = new(filePath);
            // string? line = reader.ReadLine();

            // while (line != null)
            // {
            //     version += line;
            //     line = reader.ReadLine();
            // }

            // return Ok(version);

            return Ok("Hello world");
        }
    }
}