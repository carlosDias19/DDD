
using ApplicationService.Interface;
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class DenunciasController : ControllerBase
    {
        readonly IDenunciaApplication _denunciasRepository;

        public DenunciasController(IDenunciaApplication denunciasRepository)
        {
            _denunciasRepository = denunciasRepository;
        }

        [HttpGet]
        public IActionResult GetDenuncias()
        {
            try
            {
                var denuncias = _denunciasRepository.GetDenuncia();
                return Ok(denuncias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetDenunciasById(int id)
        {
            try
            {
                var denuncias = _denunciasRepository.GetDenunciaById(id);
                return Ok(denuncias);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertDenuncias(Denuncias denuncias)
        {
            try
            {
                _denunciasRepository.InsertDenuncia(denuncias);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateDenuncias(Denuncias denuncias)
        {
            try
            {
                _denunciasRepository.UpdateDenuncia(denuncias);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDenuncias(int id)
        {
            try
            {
                _denunciasRepository.DeleteDenuncia(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
