using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Rol;
using IRepository.T_Rol;
using Repositori.T_Rol;
using RequestResponse.Request;
using RequestResponse.Request.T_Rol;
using RequestResponse.Response;
using RequestResponse.Response.T_Rol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Rol
{
    public class RolBussniess : IRolBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IRolRepository _RolRepository;
        private readonly IMapper _mapper;

        public RolBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _RolRepository = new RolRepository();

        }

        public ResponseRol Create(RequestRol entity)
        {
            Rol Rol = _mapper.Map<Rol>(entity);
            Rol = _RolRepository.Create(Rol);
            ResponseRol responseRol = _mapper.Map<ResponseRol>(Rol);
            return responseRol;
        }

        public List<ResponseRol> CreateMultiple(List<RequestRol> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _RolRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestRol> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ResponseRol> GetAll()
        {
            List<Rol> Rol = _RolRepository.GetAll();
            List<ResponseRol> responseRol = _mapper.Map<List<ResponseRol>>(Rol);
            return responseRol;

        }

        public ReponseFilterGeneric<ResponseRol> GetByFilter(RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseRol>response = _mapper.Map<ReponseFilterGeneric<ResponseRol>>(_RolRepository.GetByFilter( request));
            return response;
        }

        public ResponseRol GetById(object id)
        {
            Rol rol = _RolRepository.GetByID(id);
            ResponseRol responseRol = _mapper.Map<ResponseRol>(rol);
            return responseRol;
            
        }

        public ResponseRol Update(RequestRol entity)
        {
            Rol Rol = _mapper.Map<Rol>(entity);
            Rol = _RolRepository.Update(Rol);
            ResponseRol responseRol = _mapper.Map<ResponseRol>(Rol);
            return responseRol;
        }

        public List<ResponseRol> UpdateMultiple(List<RequestRol> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
