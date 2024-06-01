using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Producto
{
    public class ResponseVerModelos
    {
        public int IdProducto { get; set; }

        public string? NombreProd { get; set; }

        public decimal? PrecioUnitario { get; set; }

        public string? NombreModelo { get; set; }

        public string Talla { get; set; } = null!;
        public string? Color { get; set; }
    }
}
