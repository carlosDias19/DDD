
using ApplicationService.Interface;
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
        readonly ITipoDeCrimeApplication _tipoDeCrimeRepository;

        public TipoDeCrimeController(ITipoDeCrimeApplication tipoDeCrimeRepository)
        {
            _tipoDeCrimeRepository = tipoDeCrimeRepository;
        }

        [HttpGet]
        public IActionResult GetTipoDeCrime()
        {
            try
            {
                var tipoDeCrimes = _tipoDeCrimeRepository.GetTipoDeCrime();
                return Ok(tipoDeCrimes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetTipoDeCrimeById(int id)
        {
            try
            {
                var tipoDeCrimes = _tipoDeCrimeRepository.GetTipoDeCrimeById(id);
                return Ok(tipoDeCrimes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertTipoDeCrime(TipoDeCrime tipoDeCrime)
        {
            try
            {
                _tipoDeCrimeRepository.InsertTipoDeCrime(tipoDeCrime);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateTipoDeCrime(TipoDeCrime tipoDeCrime)
        {
            try
            {
                _tipoDeCrimeRepository.UpdateTipoDeCrime(tipoDeCrime);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{TipoId}")]
        public IActionResult DeleteTipoDeCrime(int TipoId)
        {
            try
            {
                _tipoDeCrimeRepository.DeleteTipoDeCrime(TipoId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
