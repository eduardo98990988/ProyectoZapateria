using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_DetalleProducto
{
    public class ResponseDetalleProducto
    {
        public string Message { get; set; } = "";
        public List<ResponseVDetalleProducto> detalleProducts { get; set; } = new List<ResponseVDetalleProducto>();
    }
}
