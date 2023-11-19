using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interface
{
    public interface ICidadeService
    {
       
        List<Cidade> GetCidade();
        Cidade GetCidadeById(int id);
       

    }
}
