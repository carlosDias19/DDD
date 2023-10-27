using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    public class Estado
    {
        [Key]
        public int EstadoId { get; set; }
        public string NomeEstado { get; set; }

    }
}
