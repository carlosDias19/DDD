
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
    public class DenunciasRepositorySqlServer : IDenunciasRepository
    {

        private readonly SqlContext _context;

        public DenunciasRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public void DeleteDenuncias(Denuncias denuncias)
        {
            try
            {
                _context.Set<Denuncias>().Remove(denuncias);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Denuncias GetDenunciasById(int id)
        {
            return _context.Denuncias.Find(id);
        }

        public List<Denuncias> GetDenuncias()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.Denuncias.ToList();

        }

        public void InsertDenuncias(Denuncias denuncias)
        {
            try
            {
                _context.Denuncias.Add(denuncias);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateDenuncias(Denuncias denuncias)
        {
            try
            {
                _context.Entry(denuncias).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
    }
}
