using Microsoft.AspNetCore.Mvc;

namespace FirstDevOps.API.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return null;
        }
    }
}
