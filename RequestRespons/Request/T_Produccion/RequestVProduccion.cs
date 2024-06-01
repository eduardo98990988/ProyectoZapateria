using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Produccion
{
    public class RequestVProduccion 
    {
         [Key]
        public int IdProduccion { get; set; }
        [StringLength(20)]

        public string CodigoProduccion { get; set; } = null!;
        public int Meta { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaInicio { get; set; }

        [StringLength(20)]
        public string EstadoProduccion { get; set; } = null!;

        public int? CantidadFaltante { get; set; }

        public int IdUnidad { get; set; }
        [StringLength(40)]
        public string? NombreProd { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaFin { get; set; }
    }
}
