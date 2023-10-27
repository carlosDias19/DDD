using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    public class TipoDeCrime
    {
        [Key]
        public int TipoId { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

    }
}
