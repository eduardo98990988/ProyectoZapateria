using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.T_Comprobante
{
    public class ResponseComprobanteDetalle
    {
        public string message { get; set; } = "";

        public List<ResponseVComprobanteDetalle> vComprobanteDetalles { get; set; } = new List<ResponseVComprobanteDetalle> { };
    }
}
