
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface ITipoDeCrimeRepository
    {
        public List<TipoDeCrime> GetTipoDeCrime();
        public TipoDeCrime GetTipoDeCrimeById(int id);
        public void InsertTipoDeCrime(TipoDeCrime tipoDeCrime);
        public void UpdateTipoDeCrime(TipoDeCrime tipoDeCrime);
        public void DeleteTipoDeCrime(TipoDeCrime tipoDeCrime);
    }
}
