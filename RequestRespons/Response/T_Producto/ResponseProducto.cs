using RequestRespons.Response.T_Proveedor;
using RequestResponse.Response.T_Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Producto
{
    public class ResponseProducto
    {
        public string message { get; set; } = null;
        public List<ResponseVProducto> productos { get; set; } = new List<ResponseVProducto>();
        
    }
}
