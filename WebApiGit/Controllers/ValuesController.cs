using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiGit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("today")]
        public IActionResult Get()
        {
            return Ok.(DateTime.Now);
        }
    }
}
