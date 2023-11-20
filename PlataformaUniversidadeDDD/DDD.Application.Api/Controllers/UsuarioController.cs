
using ApplicationService.Interface;
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        readonly IUsuarioApplication _usuarioRepository;

        public UsuarioController(IUsuarioApplication usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            return Ok(_usuarioRepository.GetUsuario());
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetById(int id)
        {
            return Ok(_usuarioRepository.GetUsuarioById(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Usuario> CreateUsuario(Usuario usuario)
        {

            _usuarioRepository.InsertUsuario(usuario);
            return CreatedAtAction(nameof(GetById), new { id = usuario.UsuarioId }, usuario);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioRepository.UpdateUsuario(usuario);
                return Ok("Usuario Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _usuarioRepository.DeleteUsuario(id);
                return Ok("Usuario Removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
