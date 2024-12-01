using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/skill")]
    [ApiController]
    public class SkillsController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetALl()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}
