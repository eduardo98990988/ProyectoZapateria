using RequestResponse.Response.T_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_DetalleEnvio
{
    public class ResponseDetalleEnvio
    {
        public string message { get; set; } = "";

        public List<ResponseVDetalleEnvio> detalleEnvios { get; set; } = new List<ResponseVDetalleEnvio>();
    }
}
