using RequestResponse.Response.T_Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Proveedor
{
    public class ResponseProveedor
    {
        public string message { get; set; } = null;
        public List<ResponseVProveedor> proveedors { get; set; } = new List<ResponseVProveedor>();
        public ResponsePersona persona { get; set; } = new ResponsePersona(); 


    }
}
