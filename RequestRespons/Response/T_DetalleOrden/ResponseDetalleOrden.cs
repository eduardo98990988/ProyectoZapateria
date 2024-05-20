using RequestResponse.Response.T_Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_DetalleOrden
{
    public class ResponseDetalleOrden
    {
        public string message { get; set; } = "";
        public List<ResponseVDetalleOrden> detalleOrdens { get; set; } = new List<ResponseVDetalleOrden>();
    }
}
