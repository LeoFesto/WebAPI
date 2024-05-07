using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly ApplicationContext _applicationContext;

        public TestController(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

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

        [HttpGet("AddString")]
        public async Task<IActionResult> AddString(string value)
        {
            try
            {
                _applicationContext.Entities.Add(new Entity { Value = value });
                await _applicationContext.SaveChangesAsync();

                return Ok($"Ok. Value '{value}' is added");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
