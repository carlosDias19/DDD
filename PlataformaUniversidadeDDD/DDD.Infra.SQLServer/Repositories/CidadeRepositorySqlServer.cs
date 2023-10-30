
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
    public class CidadeRepositorySqlServer : ICidadeRepository
    {

        private readonly SqlContext _context;

        public CidadeRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public Cidade GetCidadeById(int id)
        {
            return _context.Cidade.Find(id);
        }

        public List<Cidade> GetCidade()
        {
            //return  _context.Alunos.Include(x => x.Disciplinas).ToList();
            return _context.Cidade.ToList();

        }
       
    }
}
