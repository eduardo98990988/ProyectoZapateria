using AutoMapper;
using DBModelZapateria;
using IBussniess.T_IngresoProducto;
using IRepository.T_IngresoProducto;
using Repositori.T_IngresoProducto;
using RequestRespons.Request.T_IngresoProducto;
using RequestRespons.Response.T_IngresoProducto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_IngresoProducto
{
    public class IngresoProductoBussniess : IIngresoProductoBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IIngresoProductoRepository _IngresoProductoRepository;
        private readonly IMapper _mapper;

        public IngresoProductoBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _IngresoProductoRepository = new IngresoProductoRepository();

        }

        public ResponseVIngresoProducto Create(RequestIngresoProducto entity)
        {
            IngresoProducto IngresoProducto = _mapper.Map<IngresoProducto>(entity);
            IngresoProducto = _IngresoProductoRepository.Create(IngresoProducto);
            ResponseVIngresoProducto ResponseVIngresoProducto = _mapper.Map<ResponseVIngresoProducto>(IngresoProducto);
            return ResponseVIngresoProducto;
        }

        public List<ResponseVIngresoProducto> CreateMultiple(List<RequestIngresoProducto> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _IngresoProductoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestIngresoProducto> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVIngresoProducto> GetAll()
        {
            List<IngresoProducto> IngresoProducto = _IngresoProductoRepository.GetAll();
            List<ResponseVIngresoProducto> ResponseVIngresoProducto = _mapper.Map<List<ResponseVIngresoProducto>>(IngresoProducto);
            return ResponseVIngresoProducto;

        }

        public ResponseVIngresoProducto GetById(object id)
        {
            IngresoProducto IngresoProducto = _IngresoProductoRepository.GetByID(id);
            ResponseVIngresoProducto ResponseVIngresoProducto = _mapper.Map<ResponseVIngresoProducto>(IngresoProducto);
            return ResponseVIngresoProducto;

        }

        public ResponseVIngresoProducto Update(RequestIngresoProducto entity)
        {
            IngresoProducto IngresoProducto = _mapper.Map<IngresoProducto>(entity);
            IngresoProducto = _IngresoProductoRepository.Update(IngresoProducto);
            ResponseVIngresoProducto ResponseVIngresoProducto = _mapper.Map<ResponseVIngresoProducto>(IngresoProducto);
            return ResponseVIngresoProducto;
        }

        public List<ResponseVIngresoProducto> UpdateMultiple(List<RequestIngresoProducto> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
