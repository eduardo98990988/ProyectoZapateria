using AutoMapper;
using DBModelZapateria;
using IBussniess;
using IBussniess.T_Usuario;
using IRepository.T_Usuario;
using Repositori.T_Usuario;
using RequestResponse.Request;
using RequestResponse.Request.T_Usuario;
using RequestResponse.Response;
using RequestResponse.Response.T_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Usuario
{
    public class UsuarioBussniess : IUsuarioBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _usuarioRepository = new UsuarioRepository();

        }

        public ResponseVUsuario Create(RequestUsuario entity)
        {
           Usuario usuario = _mapper.Map<Usuario>(entity);
           usuario = _usuarioRepository.Create(usuario);
           ResponseVUsuario responseVUsuario = _mapper.Map<ResponseVUsuario>(usuario);
           return responseVUsuario;
        }

        public List<ResponseVUsuario> CreateMultiple(List<RequestUsuario> lista)
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

        public List<ResponseVUsuario> GetAll()
        {
            List<Usuario> usuario = _usuarioRepository.GetAll();
            List<ResponseVUsuario> responseVUsuario = _mapper.Map<List<ResponseVUsuario>>(usuario);
            return responseVUsuario;
     
        }

        public ReponseFilterGeneric<ResponseVUsuario> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVUsuario GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVUsuario Update(RequestUsuario entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseVUsuario> UpdateMultiple(List<RequestUsuario> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
   
    }
}
