using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet("FirstMethod")]
        public IActionResult FirstTest()
        {
            return Ok("first");
        }

        [HttpGet("SecondMethod")]
        public IActionResult SecondTest()
        {
            return Ok("second");
        }
    }
}
