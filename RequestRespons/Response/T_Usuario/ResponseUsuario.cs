using RequestResponse.Response.T_Persona;
using RequestResponse.Response.T_Produccion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.T_Usuario
{
    public class ResponseUsuario
    {
        public string message { get; set; } = "";
        public  List<ResponseVUsuario> usuarios { get; set; } = new List<ResponseVUsuario> { };
  
    }
}
