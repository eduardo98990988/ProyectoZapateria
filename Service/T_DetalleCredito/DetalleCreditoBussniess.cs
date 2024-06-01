using AutoMapper;
using DBModelZapateria;
using IBussniess.T_DetalleCredito;
using IRepository.T_DetalleCredito;
using IRepository.T_DetalleCredito;
using Repositori.T_DetalleCredito;
using RequestRespons.Request.T_DetalleCredito;
using RequestRespons.Response.T_DetalleCredito;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_DetalleCredito
{
    public class DetalleCreditoBussniess : IDetalleCreditoBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IDetalleCreditoRepository _DetalleCreditoRepository;
        private readonly IMapper _mapper;

        public DetalleCreditoBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleCreditoRepository = new DetalleCreditoRepository();

        }

        public ResponseVDetalleCredito Create(RequestDetalleCredito entity)
        {
            DetalleCredio DetalleCredito = _mapper.Map<DetalleCredio>(entity);
            DetalleCredito = _DetalleCreditoRepository.Create(DetalleCredito);
            ResponseVDetalleCredito ResponseVDetalleCredito = _mapper.Map<ResponseVDetalleCredito>(DetalleCredito);
            return ResponseVDetalleCredito;
        }

        public List<ResponseVDetalleCredito> CreateMultiple(List<RequestDetalleCredito> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _DetalleCreditoRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestDetalleCredito> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVDetalleCredito> GetAll()
        {
            List<DetalleCredio> DetalleCredito = _DetalleCreditoRepository.GetAll();
            List<ResponseVDetalleCredito> ResponseVDetalleCredito = _mapper.Map<List<ResponseVDetalleCredito>>(DetalleCredito);
            return ResponseVDetalleCredito;

        }

        public ReponseFilterGeneric<ResponseVDetalleCredito> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVDetalleCredito GetById(object id)
        {
            DetalleCredio DetalleCredito = _DetalleCreditoRepository.GetByID(id);
            ResponseVDetalleCredito ResponseVDetalleCredito = _mapper.Map<ResponseVDetalleCredito>(DetalleCredito);
            return ResponseVDetalleCredito;

        }

        public ResponseVDetalleCredito Update(RequestDetalleCredito entity)
        {
            DetalleCredio DetalleCredito = _mapper.Map<DetalleCredio>(entity);
            DetalleCredito = _DetalleCreditoRepository.Update(DetalleCredito);
            ResponseVDetalleCredito ResponseVDetalleCredito = _mapper.Map<ResponseVDetalleCredito>(DetalleCredito);
            return ResponseVDetalleCredito;
        }

        public List<ResponseVDetalleCredito> UpdateMultiple(List<RequestDetalleCredito> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
