using AutoMapper;
using Bussniess.T_Producto;
using DBModelZapateria;
using IBussniess.T_IngresoProducto;
using IBussniess.T_Producto;
using IRepository.T_Produccion;
using IRepository.T_Producto;
using Repositori.T_Produccion;
using Repositori.T_Producto;
using RequestRespons.Request.T_IngresoProducto;
using RequestRespons.Request.T_Producto;
using RequestRespons.Response.T_IngresoProducto;
using RequestRespons.Response.T_Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_IngresoProducto
{
    public class IngresoVProductoBussniess : IIngresoVProductoBussniess
    {
        private readonly IIngresoProductoBussniess _ingresoProductoBussniess;
        private readonly IProduccionRepository _produccionRepository;
        private readonly IProductoBussniess _productoBussniess;
        private readonly IProductoRepository _productoRepository;
        private readonly IMapper _mapper;

        public IngresoVProductoBussniess (IMapper mapper)
        {
            _ingresoProductoBussniess = new IngresoProductoBussniess(mapper);
            _mapper = mapper;
            _produccionRepository = new ProduccionRepository();
            _productoBussniess = new ProductoBussniess(mapper);
            _productoRepository = new ProductoRepository();

        }

        public ResponseIngresoProducto Create(RequestVIngresoProducto entity)
        {
            Producto producto = new Producto();
            producto = _productoRepository.BsucarProducto(entity.NombreProd);
            if(producto ==null) throw new Exception("No se Encontro el Producto a la esta ingresando la nueva cantidad");
            Produccion produccion = new();
            produccion = _produccionRepository.BuscarProduccion(entity.CodigoProduccion);
            if(produccion==null) throw new Exception("No se Encontro la Produccion a la que estas llamando");
            RequestIngresoProducto requesIngresoProducto = _mapper.Map<RequestIngresoProducto>(entity);
            requesIngresoProducto.IdProducto = producto.IdProducto;
            requesIngresoProducto.IdUnidad = producto.IdUnidad;
            requesIngresoProducto.IdProduccion = produccion.IdProduccion;

            ResponseVIngresoProducto responseVIngresoProducto = _ingresoProductoBussniess.Create(requesIngresoProducto);
            if (responseVIngresoProducto == null) throw new Exception("No se Pudo crear el Ingreso");
            producto.Stock += entity.Cantidad;

            RequestProducto requestProducto = _mapper.Map<RequestProducto>(producto);
            requestProducto.IdProducto=producto.IdProducto;
            ResponseVProducto responseVProducto = _productoBussniess.Update(requestProducto);
            if (responseVProducto == null) throw new Exception("No se Actualizo el Producto");

            ResponseIngresoProducto responseIngresoProducto = _mapper.Map<ResponseIngresoProducto>(responseVIngresoProducto);
            responseIngresoProducto.message = "Se creo el Ingreso de Producto";
            responseIngresoProducto.detalleProduccions.Add(responseVIngresoProducto);
            return responseIngresoProducto;
        }

        public List<ResponseIngresoProducto> CreateMultiple(List<RequestVIngresoProducto> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVIngresoProducto> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseIngresoProducto> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseIngresoProducto GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseIngresoProducto Update(RequestVIngresoProducto entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseIngresoProducto> UpdateMultiple(List<RequestVIngresoProducto> lista)
        {
            throw new NotImplementedException();
        }
    }
}
