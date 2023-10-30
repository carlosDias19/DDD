using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    public class Cidade
    {
        [Key]
        public int CidadeId { get; set; }
        public string? NomeCidade { get; set; }
        public int EstadoId { get; set; }

        [Column(TypeName = "decimal(18,7)")]
        public decimal? Latitude { get; set; }

        [Column(TypeName = "decimal(18,7)")]
        public decimal? Longitude { get; set; }
    }
}
