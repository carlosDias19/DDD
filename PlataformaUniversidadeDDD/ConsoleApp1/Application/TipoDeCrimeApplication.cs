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
    public class TipoDeCrimeApplication : ITipoDeCrimeApplication
    {
        public readonly ITipoDeCrimeService _tipoDeCrimeService;

        public TipoDeCrimeApplication(ITipoDeCrimeService tipoDeCrimeService)
        {
            _tipoDeCrimeService = tipoDeCrimeService;
        }
        public List<TipoDeCrime> GetTipoDeCrime()
        {
            return _tipoDeCrimeService.GetTipoDeCrime();
        }

        public TipoDeCrime GetTipoDeCrimeById(int id)
        {
            return _tipoDeCrimeService.GetTipoDeCrimeById(id);
        }

        public void InsertTipoDeCrime(TipoDeCrime tipoDeCrime)
        {
            _tipoDeCrimeService.InsertTipoDeCrime(tipoDeCrime);
        }

        public void UpdateTipoDeCrime(TipoDeCrime tipoDeCrime)
        {
            _tipoDeCrimeService.UpdateTipoDeCrime(tipoDeCrime);
        }

        public void DeleteTipoDeCrime(int id)
        {
            _tipoDeCrimeService.DeleteTipoDeCrime(id);
        }
    }
}
