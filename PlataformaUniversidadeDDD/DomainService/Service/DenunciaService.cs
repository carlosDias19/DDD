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
    public class DenunciaService : IDenunciaService
    {
        public readonly IDenunciasRepository _denunciaRepository;

        public DenunciaService(IDenunciasRepository denunciasRepository)
        {
            _denunciaRepository = denunciasRepository;
        }

            public List<Denuncias> GetDenuncia()
            {
                return _denunciaRepository.GetDenuncias();
            }

            public Denuncias GetDenunciaById(int id)
            {
                return _denunciaRepository.GetDenunciasById(id);
            }

            public void InsertDenuncia(Denuncias denuncia)
            {
            _denunciaRepository.InsertDenuncias(denuncia);
            }

            public void UpdateDenuncia(Denuncias denuncia)
            {
                _denunciaRepository.UpdateDenuncias(denuncia);
            }

            public void DeleteDenuncia(int id)
            {

                var denuncia = _denunciaRepository.GetDenunciasById(id);
                if (denuncia == null)
                    throw new Exception("Essa denuncia Não Existe.");

                _denunciaRepository.DeleteDenuncias(denuncia);
            }

    }
}
