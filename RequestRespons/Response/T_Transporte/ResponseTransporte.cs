using RequestRespons.Response.T_Proveedor;
using RequestResponse.Response.T_Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Transporte
{
    public class ResponseTransporte
    {
        public string message { get; set; } = null;
        public List<ResponseVTransporte> transportes { get; set; } = new List<ResponseVTransporte>();
        public ResponsePersona persona { get; set; } = new ResponsePersona();
    }
}
