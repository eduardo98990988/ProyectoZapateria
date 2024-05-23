using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_SalidaMaterial
{
    public class RequestVSalIdaMaterial
    {
        public int Cantidad { get; set; }

        [Key]

        public string CodigoProduccion { get; set; } 
        public int IdProduccion { get; set; }

        public string NombreMaterial { get; set; }
        [Key]
        public int IdMaterial { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaSalida { get; set; }

        public string NombreUnidad { get; set; }
        public int IdUnidad { get; set; }

        [Key]
        public int IdSalidaMaterial { get; set; }
    }
}
