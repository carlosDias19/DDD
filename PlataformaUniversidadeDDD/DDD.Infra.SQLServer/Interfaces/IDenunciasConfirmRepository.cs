
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IDenunciasConfirmRepository
    {
        public List<DenunciasConfirm> GetDenunciasConfirm();
        public DenunciasConfirm GetDenunciasConfirmById(int id);
        public void InsertDenunciasConfirm(DenunciasConfirm denunciasConfirm);
        public void UpdateDenunciasConfirm(DenunciasConfirm denunciasConfirm);
        public void DeleteDenunciasConfirm(DenunciasConfirm denunciasConfirm);
    }
}
