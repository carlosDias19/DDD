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
    public class DenunciaConfirmService : IDenunciaConfirmService
    {
        public readonly IDenunciasConfirmRepository _denunciaConfirmRepository;

        public DenunciaConfirmService(IDenunciasConfirmRepository denunciasConfirmRepository)
        {
            _denunciaConfirmRepository = denunciasConfirmRepository;
        }

            public List<DenunciasConfirm> GetDenunciaConfirm()
            {
                return _denunciaConfirmRepository.GetDenunciasConfirm();
            }

            public DenunciasConfirm GetDenunciaConfirmById(int id)
            {
                return _denunciaConfirmRepository.GetDenunciasConfirmById(id);
            }

            public void InsertDenunciaConfirm(DenunciasConfirm denunciaConfirm)
            {
            _denunciaConfirmRepository.InsertDenunciasConfirm(denunciaConfirm);
            }

            public void UpdateDenunciaConfirm(DenunciasConfirm denunciaConfirm)
            {
                _denunciaConfirmRepository.UpdateDenunciasConfirm(denunciaConfirm);
            }

            public void DeleteDenunciaConfirm(int id)
            {

                var denunciaConfirm = _denunciaConfirmRepository.GetDenunciasConfirmById(id);
                if (denunciaConfirm == null)
                    throw new Exception("Essa denuncia Não Existe.");

                _denunciaConfirmRepository.DeleteDenunciasConfirm(denunciaConfirm);
            }

    }
}
