using AutoMapper;
using Bussniess.Login;
using Bussniess.T_Persona;
using DBModelZapateria;
using IBussniess.Login;
using IBussniess.T_Persona;
using IBussniess.T_Usuario;
using RequestResponse.Request;
using RequestResponse.Request.T_Persona;
using RequestResponse.Request.T_Usuario;
using RequestResponse.Response;
using RequestResponse.Response.T_Persona;
using RequestResponse.Response.T_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitySecuriry;

namespace Bussniess.T_Usuario
{
    public class UsuarioVBussniess : IUsuarioVBussniess
    {
        #region Inyeccion de Dependencias
        private readonly IUsuarioBussniess _usuarioBussniess;
        private readonly ILoginBussniess _loginBussniess;
        private readonly IPersonaBussniess _personaBussniess;
        private readonly UtilEncriptarDesencriptar _cripto;
        private readonly IMapper _mapper; 

        public UsuarioVBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _personaBussniess = new PersonaBussniess(mapper);
            _loginBussniess = new LoginBussniess(mapper);
            _usuarioBussniess = new UsuarioBussniess(mapper);
            _cripto = new UtilEncriptarDesencriptar();
        }

        #endregion Fin de Inyeccion de Dependencias
        public ResponseUsuario Create(RequestUsuario entity)
        {
            ResponseUsuario responseUsuario = new ResponseUsuario();
            RequestPersona requestPersona = _mapper.Map<RequestPersona>(entity);
            ResponsePersona responsePersona = _personaBussniess.Create(requestPersona);

            // Funciona la creacion

            if (responsePersona.IdPersona != null)
            {
                RequestUsuario requestUsuario = _mapper.Map<RequestUsuario>(entity);
                requestUsuario.IdPersona = responsePersona.IdPersona;

                string paswordEncriptado = _cripto.AES_encriptar(entity.Password);
                requestUsuario.Password = paswordEncriptado; 

                if (entity.TipoPersona == "Administrador")
                {
                    requestUsuario.Irol = 1;
                } 
                if (entity.TipoPersona == "Vendedor")
                {
                    requestUsuario.Irol = 2;

                }
                if (entity.TipoPersona == "Cliente")
                {
                    requestUsuario.Irol = 3;

                }
                ResponseVUsuario resseUsuario = _usuarioBussniess.Create(requestUsuario);
                ResponseUsuario responseVUsuaro = _mapper.Map<ResponseUsuario>(resseUsuario);


                responseVUsuaro.message = "Se creo los Usuario";
                responseVUsuaro.usuarios.Add(resseUsuario);
                return responseVUsuaro;
            }
            return responseUsuario;
        }

        public List<ResponseUsuario> CreateMultiple(List<RequestUsuario> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestUsuario> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseUsuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReponseFilterGeneric<ResponseUsuario> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseUsuario GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseUsuario Update(RequestUsuario entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseUsuario> UpdateMultiple(List<RequestUsuario> lista)
        {
            throw new NotImplementedException();
        }
    }
}
