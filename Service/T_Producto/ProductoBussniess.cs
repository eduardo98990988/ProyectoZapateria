using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Producto;
using IRepository.T_DetalleProducto;
using IRepository.T_Producto;
using Repositori.T_DetalleProducto;
using Repositori.T_Producto;
using RequestRespons.Request.T_Producto;
using RequestRespons.Response.T_DetalleProducto;
using RequestRespons.Response.T_Producto;
using RequestResponse.Request;
using RequestResponse.Response;
using RequestResponse.Response.T_Rol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Producto
{
    public class ProductoBussniess : IProductoBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IProductoRepository _ProductoRepository;
        private readonly IDetalleProductoRepository _detalleProductoRepository;

        private readonly IMapper _mapper;

        public ProductoBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _ProductoRepository = new ProductoRepository();
            _detalleProductoRepository = new DetalleRepository();

        }

        public ResponseVProducto Create(RequestProducto entity)
        {
            Producto Producto = _mapper.Map<Producto>(entity);
            Producto = _ProductoRepository.Create(Producto);
            ResponseVProducto ResponseVProducto = _mapper.Map<ResponseVProducto>(Producto);
            return ResponseVProducto;
        }

        public List<ResponseVProducto> CreateMultiple(List<RequestProducto> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _ProductoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestProducto> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVProducto> GetAll()
        {
            List<Producto> Producto = _ProductoRepository.GetAll();
            List<ResponseVProducto> ResponseVProducto = _mapper.Map<List<ResponseVProducto>>(Producto);
            return ResponseVProducto;

        }

        public ReponseFilterGeneric<ResponseVProducto> GetByFilter(RequestFilterGeneric request)
        {
            ReponseFilterGeneric<ResponseVProducto> response = _mapper.Map<ReponseFilterGeneric<ResponseVProducto>>(_ProductoRepository.GetByFilter(request));
            return response;
        }

        public ResponseVProducto GetById(object id)
        {
            Producto Producto = _ProductoRepository.GetByID(id);
            ResponseVProducto ResponseVProducto = _mapper.Map<ResponseVProducto>(Producto);
            return ResponseVProducto;

        }
        public ResponseDetalleProducto GetDetalleProducto(int id)
        {
            DetalleProducto detalleProducto = _detalleProductoRepository.buscarDetalle(id);

            ResponseVDetalleProducto responseVDetalleProducto = _mapper.Map<ResponseVDetalleProducto>(detalleProducto);
            ResponseDetalleProducto responseDetalleProducto = _mapper.Map<ResponseDetalleProducto>(responseVDetalleProducto);
            responseDetalleProducto.Message = "Detalle del Producto";
            responseDetalleProducto.detalleProducts.Add(responseVDetalleProducto);

            return responseDetalleProducto;
        }
        public ResponseVProducto Update(RequestProducto entity)
        {
            Producto Producto = _mapper.Map<Producto>(entity);
            Producto = _ProductoRepository.Update(Producto);
            ResponseVProducto ResponseVProducto = _mapper.Map<ResponseVProducto>(Producto);
            return ResponseVProducto;
        }

        public List<ResponseVProducto> UpdateMultiple(List<RequestProducto> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
