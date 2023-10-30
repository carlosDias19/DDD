
using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface ICidadeRepository
    {
        public List<Cidade> GetCidade();
        public Cidade GetCidadeById(int id);

    }
}
