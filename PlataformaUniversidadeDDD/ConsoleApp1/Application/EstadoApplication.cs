using ApplicationService.Interface;
using DDD.Domain.ReportRadarContext;
using DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Application
{
    public class EstadoApplication : IEstadoApplication
    {
        public readonly IEstadoService _estadoService;

        public EstadoApplication(IEstadoService estadoService)
        {
            _estadoService = estadoService;
        }
        public List<Estado> GetEstado()
        {
            return _estadoService.GetEstado();
        }

        public Estado GetEstadoById(int id)
        {
            return _estadoService.GetEstadoById(id);
        }

    }
}
