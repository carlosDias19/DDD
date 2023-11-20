using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface IDenunciaApplication
    {
        void DeleteDenuncia(int id);
        List<Denuncias> GetDenuncia();
        Denuncias GetDenunciaById(int id);
        void InsertDenuncia(Denuncias denuncia);
        void UpdateDenuncia(Denuncias denuncia);
    }
}
