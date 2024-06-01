using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Producto
{
    public class ResponseProcedureProducto
    {
        public string? NombreProd { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrecioUnitario { get; set; }

        public int Stock { get; set; }

        public string? NombreModelo { get; set; }


        [StringLength(15)]
        public string? Color { get; set; }

        [StringLength(18)]
        public string? Material { get; set; }
    }
}
