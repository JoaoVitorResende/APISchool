using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController()
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
                return StatusCode(StatusCodes.Status503ServiceUnavailable, "Serviço indisponivel");
            }
        }
        [HttpGet("{ProfessorId}")]
        public IActionResult Get(int ProfessorId)
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
        [HttpPut("{ProfessorId}")]
        public IActionResult Put(int ProfessorId)
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
        [HttpDelete("{ProfessorId}")]
        public IActionResult Delete(int ProfessorId)
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
