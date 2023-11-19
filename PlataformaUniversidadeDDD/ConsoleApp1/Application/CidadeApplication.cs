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
    public class CidadeApplication : ICidadeApplication
    {
        public readonly ICidadeService _cidadeService;

        public CidadeApplication(ICidadeService cidadeService)
        {
            _cidadeService = cidadeService;
        }
        public List<Cidade> GetCidade()
        {
            return _cidadeService.GetCidade();
        }

        public Cidade GetCidadeById(int id)
        {
            return _cidadeService.GetCidadeById(id);
        }

    }
}
