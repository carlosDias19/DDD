
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenunciasController : ControllerBase
    {
        readonly IDenunciasRepository _denunciasRepository;

        public DenunciasController(IDenunciasRepository denunciasRepository)
        {
            _denunciasRepository = denunciasRepository;
        }

        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<Denuncias>> Get()
        {
            return Ok(_denunciasRepository.GetDenuncias());
        }

        [HttpGet("{id}")]
        public ActionResult<Denuncias> GetById(int id)
        {
            return Ok(_denunciasRepository.GetDenunciasById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Denuncias> CreateTipoDeCrime(Denuncias denuncias)
        {

            _denunciasRepository.InsertDenuncias(denuncias);
            return CreatedAtAction(nameof(GetById), new { id = denuncias.DenunciasId }, denuncias);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Denuncias denuncias)
        {
            try
            {
                _denunciasRepository.UpdateDenuncias(denuncias);
                return Ok("Denuncias Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] Denuncias denuncias)
        {
            try
            {
                if (denuncias == null)
                    return NotFound("Erro ao Deletar");

                _denunciasRepository.DeleteDenuncias(denuncias);
                return Ok("Denuncias Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
