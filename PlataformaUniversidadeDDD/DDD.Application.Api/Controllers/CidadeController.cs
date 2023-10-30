
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        readonly ICidadeRepository _CidadeRepository;

        public CidadeController(ICidadeRepository cidadeRepository)
        {
            _CidadeRepository = cidadeRepository;
        }

        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<Cidade>> Get()
        {
            return Ok(_CidadeRepository.GetCidade());
        }

        [HttpGet("{id}")]
        public ActionResult<Cidade> GetById(int id)
        {
            return Ok(_CidadeRepository.GetCidadeById(id));
        }

    }
}
