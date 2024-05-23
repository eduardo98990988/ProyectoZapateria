using RequestRespons.Response.T_DetalleProduccion;
using RequestRespons.Response.T_Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_IngresoProducto
{
    public class ResponseIngresoProducto
    {
        public string message { get; set; } = null;
        public List<ResponseVIngresoProducto> detalleProduccions { get; set; } = new List<ResponseVIngresoProducto>();
    }
}
