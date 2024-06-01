using AutoMapper;
using DBModelZapateria;
using IBussniess.T_DetalleProduccion;
using IRepository.T_DetalleProduccion;
using Repositori.T_DetalleProduccion;
using RequestRespons.Request.T_DetalleProduccion;
using RequestRespons.Response.T_DetalleProduccion;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_DetalleProduccion
{
    public class DetalleProduccionBussniess : IDetalleProduccionBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IDetalleProduccionRepository _DetalleProduccionRepository;
        private readonly IMapper _mapper;

        public DetalleProduccionBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleProduccionRepository = new DetalleProduccionRepository();

        }

        public ResponseVDetalleProduccion Create(RequestDetalleProduccion entity)
        {
            DetalleProduccion DetalleProduccion = _mapper.Map<DetalleProduccion>(entity);
            DetalleProduccion = _DetalleProduccionRepository.Create(DetalleProduccion);
            ResponseVDetalleProduccion ResponseVDetalleProduccion = _mapper.Map<ResponseVDetalleProduccion>(DetalleProduccion);
            return ResponseVDetalleProduccion;
        }

        public List<ResponseVDetalleProduccion> CreateMultiple(List<RequestDetalleProduccion> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _DetalleProduccionRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestDetalleProduccion> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVDetalleProduccion> GetAll()
        {
            List<DetalleProduccion> DetalleProduccion = _DetalleProduccionRepository.GetAll();
            List<ResponseVDetalleProduccion> ResponseVDetalleProduccion = _mapper.Map<List<ResponseVDetalleProduccion>>(DetalleProduccion);
            return ResponseVDetalleProduccion;

        }

        public ReponseFilterGeneric<ResponseVDetalleProduccion> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVDetalleProduccion GetById(object id)
        {
            DetalleProduccion DetalleProduccion = _DetalleProduccionRepository.GetByID(id);
            ResponseVDetalleProduccion ResponseVDetalleProduccion = _mapper.Map<ResponseVDetalleProduccion>(DetalleProduccion);
            return ResponseVDetalleProduccion;

        }

        public ResponseVDetalleProduccion Update(RequestDetalleProduccion entity)
        {
            DetalleProduccion DetalleProduccion = _mapper.Map<DetalleProduccion>(entity);
            DetalleProduccion = _DetalleProduccionRepository.Update(DetalleProduccion);
            ResponseVDetalleProduccion ResponseVDetalleProduccion = _mapper.Map<ResponseVDetalleProduccion>(DetalleProduccion);
            return ResponseVDetalleProduccion;
        }

        public List<ResponseVDetalleProduccion> UpdateMultiple(List<RequestDetalleProduccion> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
