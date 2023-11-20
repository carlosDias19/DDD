using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using DomainService.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
    public class UsuarioService : IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

            public List<Usuario> GetUsuario()
            {
                return _usuarioRepository.GetUsuario();
            }

            public Usuario GetUsuarioById(int id)
            {
                return _usuarioRepository.GetUsuarioById(id);
            }

            public void InsertUsuario(Usuario usuario)
            {
            _usuarioRepository.InsertUsuario(usuario);
            }

            public void UpdateUsuario(Usuario usuario)
            {
                _usuarioRepository.UpdateUsuario(usuario);
            }

            public void DeleteUsuario(int id)
            {

                var usuario = _usuarioRepository.GetUsuarioById(id);
                if (usuario == null)
                    throw new Exception("Esse Usuario Não Existe.");

                _usuarioRepository.DeleteUsuario(usuario);
            }

       
    }
}
