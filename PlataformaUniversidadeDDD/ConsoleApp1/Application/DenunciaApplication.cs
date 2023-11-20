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
    public class DenunciaApplication : IDenunciaApplication
    {
        public readonly IDenunciaService _DenunciaService;

        public DenunciaApplication(IDenunciaService DenunciaService)
        {
            _DenunciaService = DenunciaService;
        }
        public List<Denuncias> GetDenuncia()
        {
            return _DenunciaService.GetDenuncia();
        }

        public Denuncias GetDenunciaById(int id)
        {
            return _DenunciaService.GetDenunciaById(id);
        }

        public void InsertDenuncia(Denuncias denuncia)
        {
            _DenunciaService.InsertDenuncia(denuncia);
        }

        public void UpdateDenuncia(Denuncias denuncia)
        {
            _DenunciaService.UpdateDenuncia(denuncia);
        }

        public void DeleteDenuncia(int id)
        {
            _DenunciaService.DeleteDenuncia(id);
        }

        
    }
}
