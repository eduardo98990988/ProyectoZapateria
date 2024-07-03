using AutoMapper;
using DBModelZapateria;
using IBussniess.Login;
using IRepository.T_Usuario;
using Repositori.T_Usuario;
using RequestResponse.Request.Login;
using RequestResponse.Response.Login;
using RequestResponse.Response.T_Persona;
using RequestResponse.Response.T_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitySecuriry;

namespace Bussniess.Login
{
    public class LoginBussniess : ILoginBussniess
    {
        #region Inyeccion de Dependencias 
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly UtilEncriptarDesencriptar _cripto;
        private readonly IMapper _mapper;
        
        public LoginBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _usuarioRepository = new UsuarioRepository();
            _cripto = new UtilEncriptarDesencriptar();
        }

        #endregion Fin Inyeccion de Dependencias
        public ResponseLogin Login(RequestLogin login)
        {
            ResponseLogin result = new ResponseLogin();
            Persona persona = new Persona();
            VisUsuario vistUsuario  = _usuarioRepository.ObtenerUsuario(login.Usuario);
            if (vistUsuario == null)
            {
                return result;
            }
            string newPassowrd = _cripto.AES_encriptar(login.Password);
            if(newPassowrd == vistUsuario.Password)
            {
                result.Success=true;
                result.Mensaje = "Loguin Correcto";

                result.VWUsuario = new ResponseVUsuario();
                result.VWUsuario.Usuario = vistUsuario.Usuario;
                result.VWUsuario.IdUsuario = vistUsuario.IdUsuario;
                result.nameRol = vistUsuario.NombreRol;
                result.Persona = new ResponsePersona();
                result.Persona.NombrePersona = vistUsuario.NombrePersona;

                return result;
            }
            return result;
        }
    }
}
