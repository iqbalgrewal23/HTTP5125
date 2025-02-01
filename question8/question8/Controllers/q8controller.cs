using Microsoft.AspNetCore.Mvc;

namespace CSharpAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q8Controller : ControllerBase
    {
        [HttpPost("squashfellows")]
        public string SquashFellows([FromForm] int small, [FromForm] int large)
        {
        double smallPrice = 25.50;
        double largePrice = 40.50;
            double taxRate = 0.13;

        double smallTotal = small * smallPrice;
            double largeTotal = large * largePrice;
            double subtotal = smallTotal + largeTotal;
          double tax = subtotal * taxRate;
            double total = subtotal + tax;

            return $"{small} Small @ ${smallPrice:F2} = ${smallTotal:F2}; " +
                   $"{large} Large @ ${largePrice:F2} = ${largeTotal:F2}; " +
          $"Subtotal = ${subtotal:F2}; " +
          $"Tax = ${tax:F2} HST; " +
          $"Total = ${total:F2}";
        }
    }
}