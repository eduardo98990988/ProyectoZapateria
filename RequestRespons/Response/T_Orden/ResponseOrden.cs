using RequestRespons.Response.T_Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Orden
{
    public class ResponseOrden
    {
        public string message { get; set; } = null;
        public List<ResponseVOrden> ordens { get; set; } = new List<ResponseVOrden>();
    }
}
