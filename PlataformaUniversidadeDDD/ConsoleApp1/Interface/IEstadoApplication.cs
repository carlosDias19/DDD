using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface IEstadoApplication
    {
        List<Estado> GetEstado();
        Estado GetEstadoById(int id);
        
    }
}
