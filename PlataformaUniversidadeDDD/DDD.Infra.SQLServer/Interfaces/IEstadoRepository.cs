
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IEstadoRepository
    {
        public List<Estado> GetEstado();
        public Estado GetEstadoById(int id);

    }
}
