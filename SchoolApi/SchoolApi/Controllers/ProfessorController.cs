using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Data;
using SchoolApi.Models;

namespace SchoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        public IRepository _repo { get; }

        public ProfessorController(IRepository model)
        {
            _repo = model;
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
        public async Task<IActionResult> Post(Professor model)
        {
            try
            {
                _repo.Add(model);
                if (await _repo.SaveChangesAsync())
                {
                    return Created($"/api/Professores{model.Id}", model);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, "Serviço indisponivel");
            }
            return BadRequest();
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
