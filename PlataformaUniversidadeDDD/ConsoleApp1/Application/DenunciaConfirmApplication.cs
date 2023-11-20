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
    public class DenunciaConfirmApplication : IDenunciaConfirmApplication
    {
        public readonly IDenunciaConfirmService _DenunciaConfirmService;

        public DenunciaConfirmApplication(IDenunciaConfirmService DenunciaConfirmService)
        {
            _DenunciaConfirmService = DenunciaConfirmService;
        }
        public List<DenunciasConfirm> GetDenunciaConfirm()
        {
            return _DenunciaConfirmService.GetDenunciaConfirm();
        }

        public DenunciasConfirm GetDenunciaConfirmById(int id)
        {
            return _DenunciaConfirmService.GetDenunciaConfirmById(id);
        }

        public void InsertDenunciaConfirm(DenunciasConfirm denunciaConfirm)
        {
            _DenunciaConfirmService.InsertDenunciaConfirm(denunciaConfirm);
        }

        public void UpdateDenunciaConfirm(DenunciasConfirm denunciaConfirm)
        {
            _DenunciaConfirmService.UpdateDenunciaConfirm(denunciaConfirm);
        }

        public void DeleteDenunciaConfirm(int id)
        {
            _DenunciaConfirmService.DeleteDenunciaConfirm(id);
        }

        
    }
}
