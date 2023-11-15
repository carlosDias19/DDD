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
    public class TipoDeCrimeService : ITipoDeCrimeService
    {
        public readonly ITipoDeCrimeRepository _tipoDeCrimeRepository;

        public TipoDeCrimeService(ITipoDeCrimeRepository tipoDeCrimeRepository)
        {
            _tipoDeCrimeRepository = tipoDeCrimeRepository;
        }

            public List<TipoDeCrime> GetTipoDeCrime()
            {
                return _tipoDeCrimeRepository.GetTipoDeCrime();
            }

            public TipoDeCrime GetTipoDeCrimeById(int id)
            {
                return _tipoDeCrimeRepository.GetTipoDeCrimeById(id);
            }

            public void InsertTipoDeCrime(TipoDeCrime tipoDeCrime)
            {
            _tipoDeCrimeRepository.InsertTipoDeCrime(tipoDeCrime);
            }

            public void UpdateTipoDeCrime(int id, TipoDeCrime tipoDeCrime)
            {
                var tipoDeCrimeVer = _tipoDeCrimeRepository.GetTipoDeCrimeById(id);
                if (tipoDeCrimeVer == null)
                    throw new Exception("Tipo De Crime Não Existe.");

                _tipoDeCrimeRepository.UpdateTipoDeCrime(tipoDeCrime);
            }

            public void DeleteTipoDeCrime(int id)
            {

                var tipoDeCrime = _tipoDeCrimeRepository.GetTipoDeCrimeById(id);
                if (tipoDeCrime == null)
                    throw new Exception("Tipo De Crime Não Existe.");

                _tipoDeCrimeRepository.DeleteTipoDeCrime(tipoDeCrime);
            }
    }
}
