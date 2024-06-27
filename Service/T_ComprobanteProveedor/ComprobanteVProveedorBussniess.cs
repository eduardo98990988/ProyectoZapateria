using AutoMapper;
using Bussniess.T_Material;
using DBModelZapateria;
using IBussniess.T_ComprobanteProveedor;
using IBussniess.T_Material;
using IRepository.T_Material;
using Repositori.T_Material;
using RequestRespons.Request.T_ComprobanteProveedor;
using RequestRespons.Response.T_ComprobanteProveedor;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_ComprobanteProveedor
{
    public class ComprobanteVProveedorBussniess : IComprobanteVProveedorBussniess
    {
        #region Inyeccion de Dependencias
        private readonly IMaterialBussniess _materialBussniess;
        private readonly IComprobanteProveedorBussniess _comprobanteProveedorBussniess;
        private readonly IMapper _mapper;
        private readonly IMaterialRepository _materialrRepository;

        public  ComprobanteVProveedorBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _materialrRepository = new MaterialRepository();
            _comprobanteProveedorBussniess = new ComprobanteProveedorBussniess(mapper);
            _materialBussniess = new MaterialBussniess(mapper);
        }

        #endregion Inyeccion de Dependencias
        public ResponseComprobanteProveedor Create(RequestVComprobanteProveedor entity)
        {
            ResponseComprobanteProveedor response = new ResponseComprobanteProveedor();
            Material material = _materialrRepository.buscarMaterial(entity.NombreMaterial);
            if(material == null)
            {
                response.message = "No se encontro el material";
            }
            material.Stock += entity.Cantidad;
            material = _materialrRepository.Update(material);
            RequestComprobanteProveedor requestComprobante = _mapper.Map<RequestComprobanteProveedor>(entity);

            ResponseVComprobanteProveedor responseComprobante = _comprobanteProveedorBussniess.Create(requestComprobante);
            response = _mapper.Map<ResponseComprobanteProveedor>(responseComprobante);
            response.message = "Se creo el Comprobante";
            response.comprobanteProveedors.Add(responseComprobante);
            return response;
        }

        public List<ResponseComprobanteProveedor> CreateMultiple(List<RequestVComprobanteProveedor> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVComprobanteProveedor> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseComprobanteProveedor> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReponseFilterGeneric<ResponseComprobanteProveedor> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseComprobanteProveedor GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseComprobanteProveedor Update(RequestVComprobanteProveedor entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseComprobanteProveedor> UpdateMultiple(List<RequestVComprobanteProveedor> lista)
        {
            throw new NotImplementedException();
        }
    }
}
