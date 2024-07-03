using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Proveedor;
using IRepository.T_Proveedor;
using Repositori.T_Proveedor;
using RequestRespons.Request.T_Proveedor;
using RequestRespons.Response.T_Orden;
using RequestRespons.Response.T_Proveedor;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Proveedor
{
    public class ProveedorVBussniess : IProveedorVBussniess
    {
        private readonly IProveedorRepository _proveedorRepsoitory;
        private readonly IProveedorVRepository _proveedorVRepository;
        private readonly IProveedorBussniess _proveedorBussniess;
        private readonly IMapper _mapper;

        public ProveedorVBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _proveedorBussniess = new ProveedorBussniess(mapper);
            _proveedorRepsoitory = new ProveedorRepository();
            _proveedorVRepository = new ProveedorVRepository();
        }
        public ResponseProveedor Create(RequestVProveedor entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseProveedor> CreateMultiple(List<RequestVProveedor> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVProveedor> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseProveedor> GetAll()
        {

            List<ResponseProveedor> responseOrdens = new List<ResponseProveedor>();
            ResponseProveedor response = new ResponseProveedor();
            response.proveedors = new List<ResponseVProveedor>();

            List<VisProveedor> vistOrdens = _proveedorVRepository.GetAll();
            response.proveedors = _mapper.Map<List<ResponseVProveedor>>(vistOrdens);
            response.message = "Lista de Ordenes de la empresa";
            responseOrdens.Add(response);
            return responseOrdens;
        }

        public ReponseFilterGeneric<ResponseProveedor> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseProveedor GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseProveedor Update(RequestVProveedor entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseProveedor> UpdateMultiple(List<RequestVProveedor> lista)
        {
            throw new NotImplementedException();
        }
    }
}
