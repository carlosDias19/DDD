using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface ICidadeApplication
    {
        List<Cidade> GetCidade();
        Cidade GetCidadeById(int id);
        
    }
}
