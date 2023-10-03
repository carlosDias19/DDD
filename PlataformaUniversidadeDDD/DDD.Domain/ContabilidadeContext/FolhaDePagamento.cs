using DDD.Domain.PicContext;
using DDD.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ContabilidadeContext
{
    public class FolhaDePagamento
    {
        public string Titulacao { get; set; }
        public List<Projeto> Projetos { get; set; }
    }
}
