
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
    public class DenunciasConfirmRepositorySqlServer : IDenunciasConfirmRepository
    {

        private readonly SqlContext _context;

        public DenunciasConfirmRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public void DeleteDenunciasConfirm(DenunciasConfirm denunciasConfirm)
        {
            try
            {
                _context.Set<DenunciasConfirm>().Remove(denunciasConfirm);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DenunciasConfirm GetDenunciasConfirmById(int id)
        {
            return _context.DenunciasConfirm.Find(id);
        }

        public List<DenunciasConfirm> GetDenunciasConfirm()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.DenunciasConfirm.ToList();

        }

        public void InsertDenunciasConfirm(DenunciasConfirm denunciasConfirm)
        {
            try
            {
                _context.DenunciasConfirm.Add(denunciasConfirm);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }


        public void UpdateDenunciasConfirm(DenunciasConfirm denunciasConfirm)
        {
            try
            {
                _context.Entry(denunciasConfirm).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
    }
}
