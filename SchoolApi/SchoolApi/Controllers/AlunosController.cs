using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Data;
using SchoolApi.Models;

namespace SchoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        public IRepository _repo { get; }

        public AlunosController(IRepository repo)
        {
            _repo = repo;
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
        public async Task<IActionResult> Post(Aluno model)
        {
            try
            {
                _repo.Add(model);
                if (await _repo.SaveChangesAsync())
                {
                    return Created($"/api/Alunos{model.Id}", model);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status503ServiceUnavailable, "Serviço indisponivel");
            }
            return BadRequest();
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
