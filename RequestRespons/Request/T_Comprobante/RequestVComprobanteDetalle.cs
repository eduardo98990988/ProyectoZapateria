using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Comprobante
{
    public class RequestVComprobanteDetalle
    {
        public int Cantidad { get; set; }

        [Key]
        public int IdComprobante { get; set; }

        [Key]
        public int IdMaterial { get; set; }

        [StringLength(50)]
        public string NombreMaterial { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal PrecioUnitario { get; set; }

        public int IdUnidad { get; set; }


        [StringLength(30)]
        public string? NombreUnidad { get; set; }

    }
}
