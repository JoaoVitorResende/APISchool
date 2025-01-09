using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        public AlunosController()
        {
            
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        [HttpGet("{AlunoId}")]
        public IActionResult Get(int AlunoId)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
        [HttpPut("{AlunoId}")]
        public IActionResult Put(int AlunoId) 
        {
            return Ok();
        }
        [HttpDelete("{AlunoId}")]
        public IActionResult Delete(int AlunoId) 
        {
            return Ok();
        }
    }
}
