using Microsoft.AspNetCore.Mvc;
using System;

namespace CSharpAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Q7Controller : ControllerBase
    {
        [HttpGet("timemachine")]
        public string TimeMachine(int days)
        {
            DateTime adjustedDate = DateTime.Today.AddDays(days);
            return adjustedDate.ToString("yyyy-MM-dd");
        }
    }
}