using RequestResponse.Response.T_Persona;
using RequestResponse.Response.T_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.Login
{
    public class ResponseLogin
    {
        public bool Success { get; set; } = false;
        public string Mensaje { get; set; } = "Usuario y/o password incorrecto";
        public string Token { get; set; } = "";
        public string TokenExpira { get; set; } = "";
        public string nameRol { get; set; } = "";
        public string name { get; set; } = "";
        public ResponseVUsuario? VWUsuario { get; set; } = null;
        public ResponsePersona? Persona { get; set; } = null;
        //public UsuarioLoginResponse? Usuario { get; set; } = null;
        //public RolResponse? Rol { get; set; } = null;
        //public PersonaResponse? Persona { get; set; } = null;
    }
}
