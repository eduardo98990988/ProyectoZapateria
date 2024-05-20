using RequestRespons.Response.T_ComprobanteProveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Cliente
{
    public class ResponseCliente
    {
        public string message { get; set; } = null;
        public List<ResponseVCliente> clientes { get; set; } = new List<ResponseVCliente>();
    }
}
