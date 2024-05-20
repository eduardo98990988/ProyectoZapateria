using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_IngresoProducto
{
    public class RequestVIngresoProducto
    {

        [Key]
        public int IdProduccion { get; set; }

        [StringLength(20)]

        public string CodigoProduccion { get; set; } = null!;

        [Key]
        public int IdProducto { get; set; }

        [StringLength(40)]
        public string? NombreProd { get; set; }

        public int Cantidad { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }

        public int IdUnidad { get; set; }

        [StringLength(30)]
        public string? NombreUnidad { get; set; }


    }
}
