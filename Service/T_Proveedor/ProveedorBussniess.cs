using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Proveedor;
using IRepository.T_Proveedor;
using Repositori.T_Proveedor;
using RequestRespons.Request.T_Proveedor;
using RequestRespons.Response.T_Proveedor;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Proveedor
{
    public class ProveedorBussniess : IProveedorBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IProveedorRepository _ProveedorRepository;
        private readonly IMapper _mapper;

        public ProveedorBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _ProveedorRepository = new ProveedorRepository();

        }

        public ResponseVProveedor Create(RequestProveedor entity)
        {
            Provedor proveedor = _mapper.Map<Provedor>(entity);
            proveedor = _ProveedorRepository.Create(proveedor);
            ResponseVProveedor ResponseVProveedor = _mapper.Map<ResponseVProveedor>(proveedor);
            return ResponseVProveedor;
        }

        public List<ResponseVProveedor> CreateMultiple(List<RequestProveedor> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _ProveedorRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestProveedor> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVProveedor> GetAll()
        {
            List<Provedor> Proveedor = _ProveedorRepository.GetAll();
            List<ResponseVProveedor> ResponseVProveedor = _mapper.Map<List<ResponseVProveedor>>(Proveedor);
            return ResponseVProveedor;

        }

        public ReponseFilterGeneric<ResponseVProveedor> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVProveedor GetById(object id)
        {
            Provedor Proveedor = _ProveedorRepository.GetByID(id);
            ResponseVProveedor ResponseVProveedor = _mapper.Map<ResponseVProveedor>(Proveedor);
            return ResponseVProveedor;

        }

        public ResponseVProveedor Update(RequestProveedor entity)
        {
            Provedor Proveedor = _mapper.Map<Provedor>(entity);
            Proveedor = _ProveedorRepository.Update(Proveedor);
            ResponseVProveedor ResponseVProveedor = _mapper.Map<ResponseVProveedor>(Proveedor);
            return ResponseVProveedor;
        }

        public List<ResponseVProveedor> UpdateMultiple(List<RequestProveedor> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
