using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q2Controller : ControllerBase
    {
        [HttpGet("greeting")]
        public IActionResult Greeting(string name)
        {
            var message = "Hi " + name + "!";
            return Ok(message);
        }
    }
}