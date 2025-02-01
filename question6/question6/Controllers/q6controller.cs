using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q6Controller : ControllerBase
    {
        [HttpGet("hexagon")]
        public double Hexagon(double side)
        {
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return area;
        }
    }
}