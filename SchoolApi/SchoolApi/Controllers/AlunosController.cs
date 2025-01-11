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
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable,"Serviço indisponivel");
            }
            
        }
        [HttpGet("{AlunoId}")]
        public IActionResult Get(int AlunoId)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, "Serviço indisponivel");
            }
        }
        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, "Serviço indisponivel");
            }
        }
        [HttpPut("{AlunoId}")]
        public IActionResult Put(int AlunoId) 
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, "Serviço indisponivel");
            }
        }
        [HttpDelete("{AlunoId}")]
        public IActionResult Delete(int AlunoId) 
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, "Serviço indisponivel");
            }
        }
    }
}
