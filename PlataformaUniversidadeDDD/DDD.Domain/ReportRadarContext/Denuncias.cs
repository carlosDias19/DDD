using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ReportRadarContext
{
    public class Denuncias
    {
        [Key]
        public int DenunciasId { get; set; }
        public int TipoId { get; set; }
        public int UsuarioId { get; set; }
        public int CEP { get; set; }
        public string? Endereco { get; set; }
        public int Numero { get;set; }
        public string? Bairro { get; set;}
        public string Complemento { get; set;}

        [Column(TypeName = "decimal(18,7)")]
        public decimal? Latitude { get; set; }

        [Column(TypeName = "decimal(18,7)")]
        public decimal? Longitude { get; set; }

    }
}
