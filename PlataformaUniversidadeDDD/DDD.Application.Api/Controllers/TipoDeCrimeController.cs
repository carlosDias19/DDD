
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDeCrimeController : ControllerBase
    {
        readonly ITipoDeCrimeRepository _tipoDeCrimeRepository;

        public TipoDeCrimeController(ITipoDeCrimeRepository tipoDeCrimeRepository)
        {
            _tipoDeCrimeRepository = tipoDeCrimeRepository;
        }

        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<TipoDeCrime>> Get()
        {
            return Ok(_tipoDeCrimeRepository.GetTipoDeCrime());
        }

        [HttpGet("{id}")]
        public ActionResult<TipoDeCrime> GetById(int id)
        {
            return Ok(_tipoDeCrimeRepository.GetTipoDeCrimeById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<TipoDeCrime> CreateTipoDeCrime(TipoDeCrime tipoDeCrime)
        {

            _tipoDeCrimeRepository.InsertTipoDeCrime(tipoDeCrime);
            return CreatedAtAction(nameof(GetById), new { id = tipoDeCrime.TipoId }, tipoDeCrime);
        }

        [HttpPut]
        public ActionResult Put([FromBody] TipoDeCrime tipoDeCrime)
        {
            try
            {
                _tipoDeCrimeRepository.UpdateTipoDeCrime(tipoDeCrime);
                return Ok("Tipo De Crime Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] TipoDeCrime tipoDeCrime)
        {
            try
            {
                if (tipoDeCrime == null)
                    return NotFound("Erro ao Deletar");

                _tipoDeCrimeRepository.DeleteTipoDeCrime(tipoDeCrime);
                return Ok("Tipo De Crime Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
