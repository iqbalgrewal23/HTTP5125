using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q5Controller : ControllerBase
    {
        [HttpPost("secret")]
        public string Secret([FromBody] int secret)
        {
            string message = "Shh.. the secret is " + secret;
            return message;
        }
    }
}


