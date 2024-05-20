using AutoMapper;
using DBModelZapateria;
using IBussniess.T_DetalleEnvio;
using IRepository.T_DetalleEnvio;
using Repositori.T_DetalleEnvio;
using RequestRespons.Request.T_DetalleEnvio;
using RequestRespons.Response.T_DetalleEnvio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_DetalleEnvio
{
    public class DetalleEnvioBussniess : IDetalleEnvioBussniess
    {
        #region Inyeccion de Dependencias

        private readonly IDetalleEnvioRepository _DetalleEnvioRepository;
        private readonly IMapper _mapper;

        public DetalleEnvioBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _DetalleEnvioRepository = new DetalleEnvioRepository();

        }

        public ResponseVDetalleEnvio Create(RequestDetalleEnvio entity)
        {
            DetalleEnvio DetalleEnvio = _mapper.Map<DetalleEnvio>(entity);
            DetalleEnvio = _DetalleEnvioRepository.Create(DetalleEnvio);
            ResponseVDetalleEnvio ResponseVDetalleEnvio = _mapper.Map<ResponseVDetalleEnvio>(DetalleEnvio);
            return ResponseVDetalleEnvio;
        }

        public List<ResponseVDetalleEnvio> CreateMultiple(List<RequestDetalleEnvio> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _DetalleEnvioRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestDetalleEnvio> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVDetalleEnvio> GetAll()
        {
            List<DetalleEnvio> DetalleEnvio = _DetalleEnvioRepository.GetAll();
            List<ResponseVDetalleEnvio> ResponseVDetalleEnvio = _mapper.Map<List<ResponseVDetalleEnvio>>(DetalleEnvio);
            return ResponseVDetalleEnvio;

        }

        public ResponseVDetalleEnvio GetById(object id)
        {
            DetalleEnvio DetalleEnvio = _DetalleEnvioRepository.GetByID(id);
            ResponseVDetalleEnvio ResponseVDetalleEnvio = _mapper.Map<ResponseVDetalleEnvio>(DetalleEnvio);
            return ResponseVDetalleEnvio;

        }

        public ResponseVDetalleEnvio Update(RequestDetalleEnvio entity)
        {
            DetalleEnvio DetalleEnvio = _mapper.Map<DetalleEnvio>(entity);
            DetalleEnvio = _DetalleEnvioRepository.Update(DetalleEnvio);
            ResponseVDetalleEnvio ResponseVDetalleEnvio = _mapper.Map<ResponseVDetalleEnvio>(DetalleEnvio);
            return ResponseVDetalleEnvio;
        }

        public List<ResponseVDetalleEnvio> UpdateMultiple(List<RequestDetalleEnvio> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
