using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringController : ControllerBase
    {
        private static readonly List<string> names = new List<string>
        {
            "John",
            "Jane",
            "Michael",
            "Emily"
        };

        private const string helloWorldText = "Hello, World!";
        private const string fullName = "John Doe";

        [HttpGet("getHelloWorld")]
        public ActionResult<string> GetHelloWorld()
        {
            return Ok(helloWorldText);
        }

        [HttpGet("getNames")]
        public ActionResult<IEnumerable<string>> GetNames()
        {
            return Ok(names);
        }

        [HttpGet("getFullName")]
        public ActionResult<string> GetFullName()
        {
            return Ok(fullName);
        }
    }
}
