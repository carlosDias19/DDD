using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interface
{
    public interface ITipoDeCrimeService
    {
        void DeleteTipoDeCrime(int id);
        List<TipoDeCrime> GetTipoDeCrime();
        TipoDeCrime GetTipoDeCrimeById(int id);
        void InsertTipoDeCrime(TipoDeCrime tipoDeCrime);
        void UpdateTipoDeCrime(TipoDeCrime tipoDeCrime);

    }
}
