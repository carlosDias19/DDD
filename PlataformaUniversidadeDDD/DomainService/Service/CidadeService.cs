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
    public class CidadeService : ICidadeService
    {
        public readonly ICidadeRepository _cidadeRepository;

        public CidadeService(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

            public List<Cidade> GetCidade()
            {
                return _cidadeRepository.GetCidade();
            }

            public Cidade GetCidadeById(int id)
            {
                return _cidadeRepository.GetCidadeById(id);
            }         
    }
}
