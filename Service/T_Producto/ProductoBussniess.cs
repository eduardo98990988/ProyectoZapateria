using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Producto;
using IRepository.T_Producto;
using Repositori.T_Producto;
using RequestRespons.Request.T_Producto;
using RequestRespons.Response.T_Producto;
using RequestResponse.Request;
using RequestResponse.Response;
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
        private readonly IMapper _mapper;

        public ProductoBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _ProductoRepository = new ProductoRepository();

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
            throw new NotImplementedException();
        }

        public ResponseVProducto GetById(object id)
        {
            Producto Producto = _ProductoRepository.GetByID(id);
            ResponseVProducto ResponseVProducto = _mapper.Map<ResponseVProducto>(Producto);
            return ResponseVProducto;

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
