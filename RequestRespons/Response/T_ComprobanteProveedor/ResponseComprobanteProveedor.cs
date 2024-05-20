using RequestRespons.Response.T_Transporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_ComprobanteProveedor
{
    public class ResponseComprobanteProveedor
    {
        public string message { get; set; } = null;
        public List<ResponseVComprobanteProveedor> comprobanteProveedors { get; set; } = new List<ResponseVComprobanteProveedor>();
    }
}
