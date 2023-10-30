
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IDenunciasRepository
    {
        public List<Denuncias> GetDenuncias();
        public Denuncias GetDenunciasById(int id);
        public void InsertDenuncias(Denuncias denuncias);
        public void UpdateDenuncias(Denuncias denuncias);
        public void DeleteDenuncias(Denuncias denuncias);
    }
}
