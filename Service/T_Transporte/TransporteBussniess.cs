using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Transporte;
using IRepository.T_Transporte;
using Repositori.T_Transporte;
using RequestRespons.Request.T_Transporte;
using RequestRespons.Response.T_Transporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Transporte
{
    public class TransporteBussniess : ITransporteBussniess
    {
        #region Inyeccion de Dependencias

        private readonly ITransporteRepository _TransporteRepository;
        private readonly IMapper _mapper;

        public TransporteBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _TransporteRepository = new TransporteRepository();

        }

        public ResponseVTransporte Create(RequestTransporte entity)
        {
            Trasporte Transporte = _mapper.Map<Trasporte>(entity);
            Transporte = _TransporteRepository.Create(Transporte);
            ResponseVTransporte ResponseVTransporte = _mapper.Map<ResponseVTransporte>(Transporte);
            return ResponseVTransporte;
        }

        public List<ResponseVTransporte> CreateMultiple(List<RequestTransporte> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            int cantidad = _TransporteRepository.Delete(id);
            return cantidad;
        }

        public int DeleteMultiple(List<RequestTransporte> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVTransporte> GetAll()
        {
            List<Trasporte> Transporte = _TransporteRepository.GetAll();
            List<ResponseVTransporte> ResponseVTransporte = _mapper.Map<List<ResponseVTransporte>>(Transporte);
            return ResponseVTransporte;

        }

        public ResponseVTransporte GetById(object id)
        {
            Trasporte Transporte = _TransporteRepository.GetByID(id);
            ResponseVTransporte ResponseVTransporte = _mapper.Map<ResponseVTransporte>(Transporte);
            return ResponseVTransporte;

        }

        public ResponseVTransporte Update(RequestTransporte entity)
        {
            Trasporte Transporte = _mapper.Map<Trasporte>(entity);
            Transporte = _TransporteRepository.Update(Transporte);
            ResponseVTransporte ResponseVTransporte = _mapper.Map<ResponseVTransporte>(Transporte);
            return ResponseVTransporte;
        }

        public List<ResponseVTransporte> UpdateMultiple(List<RequestTransporte> lista)
        {
            throw new NotImplementedException();
        }

        #endregion Fin Inyeccion de Dependencias
    }
}
