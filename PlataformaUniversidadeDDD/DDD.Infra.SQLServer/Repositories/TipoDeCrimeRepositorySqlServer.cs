
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class TipoDeCrimeRepositorySqlServer : ITipoDeCrimeRepository
    {

        private readonly SqlContext _context;

        public TipoDeCrimeRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public void DeleteTipoDeCrime(TipoDeCrime tipoDeCrime)
        {
            try
            {
                _context.Set<TipoDeCrime>().Remove(tipoDeCrime);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public TipoDeCrime GetTipoDeCrimeById(int id)
        {
            return _context.TipoDeCrime.Find(id);
        }

        public List<TipoDeCrime> GetTipoDeCrime()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.TipoDeCrime.ToList();

        }

        public void InsertTipoDeCrime(TipoDeCrime tipoDeCrime)
        {
            try
            {
                _context.TipoDeCrime.Add(tipoDeCrime);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void UpdateTipoDeCrime(TipoDeCrime tipoDeCrime)
        {
            try
            {
                _context.Entry(tipoDeCrime).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
