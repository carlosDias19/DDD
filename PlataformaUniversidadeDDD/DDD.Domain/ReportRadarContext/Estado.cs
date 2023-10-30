using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    public class Estado
    {
        [Key]
        public int EstadoId { get; set; }
        public string? NomeEstado { get; set; }
        public string? SiglaEstado { get; set; }

        [Column(TypeName = "decimal(18,7)")]
        public decimal? Latitude { get; set; }

        [Column(TypeName = "decimal(18,7)")]
        public decimal? Longitude { get; set; }
    }
}
