using AutoMapper;
using Bussniess.T_ComprobanteProveedor;
using DBModelZapateria;
using IBussniess.T_Comprobante;
using IBussniess.T_ComprobanteProveedor;
using IRepository.T_Material;
using IRepository.T_Unidad;
using Repositori.T_Material;
using Repositori.T_Unidad;
using RequestRespons.Request.T_Comprobante;
using RequestRespons.Request.T_ComprobanteProveedor;
using RequestRespons.Response.T_ComprobanteProveedor;
using RequestResponse.Request.T_Comprobante;
using RequestResponse.Response.T_Comprobante;
using RequestResponse.Response.T_Unidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Comprobante
{
    public class ComprobanteVDetalleBussniess : IComprobanteVDetalleBussniess
    {
        private readonly IMaterialRepository _materialRepository;
        private readonly IUnidadRespository _unidadRepository;
        private readonly IComprobanteDetalleBussniess _comprobanteDetalleBussniess;
        private readonly IComprobanteProveedorBussniess _comprobanteProveedorBussniess;
        private readonly IMapper _mapper;

        public ComprobanteVDetalleBussniess (IMapper mapper)
        {
            _materialRepository = new MaterialRepository();
            _unidadRepository = new UnidadRepository();
            _comprobanteDetalleBussniess = new ComprobanteDetalleBussniess(mapper);
            _comprobanteProveedorBussniess = new ComprobanteProveedorBussniess(mapper);
            _mapper = mapper;

        }
        public ResponseComprobanteDetalle Create(RequestVComprobanteProveedor entity)
        {
            Unidad responseUnidad = _mapper.Map<Unidad>(entity);
            responseUnidad = _unidadRepository.BuscarUnidad(entity.NombreUnidad);
            Material material = _materialRepository.buscarMaterial(entity.NombreMaterial);

            responseUnidad.IdUnidad= entity.IdUnidad;
            material.IdMaterial= entity.IdMaterial;

            RequestComprobanteDetalle requestComprobante= _mapper.Map<RequestComprobanteDetalle>(responseUnidad);
            requestComprobante = _mapper.Map<RequestComprobanteDetalle>(material);

            ResponseVComprobanteDetalle responseComprobante = _comprobanteDetalleBussniess.Create(requestComprobante);

            RequestComprobanteProveedor requestComprobanteProveedor = new RequestComprobanteProveedor();
            requestComprobanteProveedor.IdComprobante = responseComprobante.IdComprobante;

            ResponseVComprobanteProveedor responseVComprobanteProveedor = _mapper.Map<ResponseVComprobanteProveedor>(responseComprobante);
            responseVComprobanteProveedor = _comprobanteProveedorBussniess.Create(requestComprobanteProveedor);

            ResponseComprobanteDetalle responseVComprobante = _mapper.Map<ResponseComprobanteDetalle>(responseVComprobanteProveedor);
            responseVComprobante.message = "Se creo el Comprobante";

            responseVComprobante.vComprobanteDetalles.Add(responseComprobante);
            return responseVComprobante;
        }

        public List<ResponseComprobanteDetalle> CreateMultiple(List<RequestVComprobanteProveedor> lista)
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

        public List<ResponseComprobanteDetalle> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseComprobanteDetalle GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseComprobanteDetalle Update(RequestVComprobanteProveedor entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseComprobanteDetalle> UpdateMultiple(List<RequestVComprobanteProveedor> lista)
        {
            throw new NotImplementedException();
        }
    }
}
