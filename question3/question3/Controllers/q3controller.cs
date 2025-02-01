using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q3Controller : ControllerBase
    {
        [HttpGet("cube/{baseNumber}")]
        public int Cube(int baseNumber)
        {
            int result = baseNumber * baseNumber * baseNumber;
            return result;
        }
    }
}