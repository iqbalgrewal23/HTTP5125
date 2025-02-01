using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q4Controller : ControllerBase
    {
        [HttpPost("knockknock")]
        public string KnockKnock()
        {
            string joke = "Who’s there?";
            return joke;
        }
    }
}