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
        public int IdIngresoProducto { get; set; }

        [StringLength(20)]


        [Required]
        public string CodigoProduccion { get; set; } = null!;

        [StringLength(40)]
        [Required]
        public string? NombreProd { get; set; }
        [Required]
        public int Cantidad { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaIngreso { get; set; }


    }
}
