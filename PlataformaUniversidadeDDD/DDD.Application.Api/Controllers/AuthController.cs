using DDD.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string Email, string Senha)
        {
            if (Email == "teste" && Senha == "123")
            {
                var token = TokenService.GenerateToken(new Domain.ReportRadarContext.Usuario());
                return Ok(token);
            }

            return BadRequest("Email ou Senha invalido");
        }
    }
}
