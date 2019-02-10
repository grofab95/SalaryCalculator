using Microsoft.AspNetCore.Mvc;

namespace SalaryCalculator.RestApi
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public IActionResult Value()
        {
            return Ok("Hey!");
        }
    }
}
