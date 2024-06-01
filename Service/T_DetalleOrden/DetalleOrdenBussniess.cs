using AutoMapper;
using DBModelZapateria;
using IBussniess.T_DetalleOrden;
using IRepository.T_DetalleOrden;
using Repositori.T_DetalleOrden;
using RequestRespons.Request.T_DetalleOrden;
using RequestRespons.Response.T_DetalleOrden;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_DetalleOrden
{
    public class DetalleOrdenBussniess : IDetalleOrdenBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IDetalleOrdenRepository _DetalleOrdenRepository;
        private readonly IMapper _mapper;

        public DetalleOrdenBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleOrdenRepository = new DetalleOrdenRepository();

        }

        public ResponseVDetalleOrden Create(RequestDetalleOrden entity)
        {
            DetalleOrden DetalleOrden = _mapper.Map<DetalleOrden>(entity);
            DetalleOrden = _DetalleOrdenRepository.Create(DetalleOrden);
            ResponseVDetalleOrden ResponseVDetalleOrden = _mapper.Map<ResponseVDetalleOrden>(DetalleOrden);
            return ResponseVDetalleOrden;
        }

        public List<ResponseVDetalleOrden> CreateMultiple(List<RequestDetalleOrden> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _DetalleOrdenRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestDetalleOrden> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVDetalleOrden> GetAll()
        {
            List<DetalleOrden> DetalleOrden = _DetalleOrdenRepository.GetAll();
            List<ResponseVDetalleOrden> ResponseVDetalleOrden = _mapper.Map<List<ResponseVDetalleOrden>>(DetalleOrden);
            return ResponseVDetalleOrden;

        }

        public ReponseFilterGeneric<ResponseVDetalleOrden> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVDetalleOrden GetById(object id)
        {
            DetalleOrden DetalleOrden = _DetalleOrdenRepository.GetByID(id);
            ResponseVDetalleOrden ResponseVDetalleOrden = _mapper.Map<ResponseVDetalleOrden>(DetalleOrden);
            return ResponseVDetalleOrden;

        }

        public ResponseVDetalleOrden Update(RequestDetalleOrden entity)
        {
            DetalleOrden DetalleOrden = _mapper.Map<DetalleOrden>(entity);
            DetalleOrden = _DetalleOrdenRepository.Update(DetalleOrden);
            ResponseVDetalleOrden ResponseVDetalleOrden = _mapper.Map<ResponseVDetalleOrden>(DetalleOrden);
            return ResponseVDetalleOrden;
        }

        public List<ResponseVDetalleOrden> UpdateMultiple(List<RequestDetalleOrden> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
