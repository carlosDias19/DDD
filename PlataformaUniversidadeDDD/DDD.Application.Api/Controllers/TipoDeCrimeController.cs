
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

        [HttpPut("{id}")]
        public IActionResult UpdateTipoDeCrime(int id, TipoDeCrime tipoDeCrime)
        {
            try
            {
                _tipoDeCrimeRepository.UpdateTipoDeCrime(id, tipoDeCrime);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTipoDeCrime(int id)
        {
            try
            {
                _tipoDeCrimeRepository.DeleteTipoDeCrime(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
