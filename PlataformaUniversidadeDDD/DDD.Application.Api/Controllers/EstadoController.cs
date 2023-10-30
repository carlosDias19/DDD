
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        readonly IEstadoRepository _EstadoRepository;

        public EstadoController(IEstadoRepository estadoRepository)
        {
            _EstadoRepository = estadoRepository;
        }

        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<Estado>> Get()
        {
            return Ok(_EstadoRepository.GetEstado());
        }

        [HttpGet("{id}")]
        public ActionResult<Estado> GetById(int id)
        {
            return Ok(_EstadoRepository.GetEstadoById(id));
        }

    }
}
