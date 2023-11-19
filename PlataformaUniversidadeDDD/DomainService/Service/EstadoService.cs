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
    public class EstadoService : IEstadoService
    {
        public readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

            public List<Estado> GetEstado()
            {
                return _estadoRepository.GetEstado();
            }

            public Estado GetEstadoById(int id)
            {
                return _estadoRepository.GetEstadoById(id);
            }       
    }
}
