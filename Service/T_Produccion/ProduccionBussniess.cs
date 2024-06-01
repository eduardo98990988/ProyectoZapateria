using AutoMapper;
using DBModelZapateria;
using IBussniess.T_Produccion;
using IRepository.T_Produccion;
using Repositori.T_Produccion;
using RequestResponse.Request;
using RequestResponse.Request.T_Produccion;
using RequestResponse.Response;
using RequestResponse.Response.T_Produccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussniess.T_Produccion
{
    public class ProduccionBussniess : IProduccionBussniess
    {
        #region Inyeccion de Dependencias
        private readonly IProduccionRepository _ProduccionRepository;
        private readonly IMapper _mapper;

        public ProduccionBussniess(IMapper mapper)
        {
            _mapper = mapper;
            _ProduccionRepository = new ProduccionRepository();

        }

        #endregion Fin Inyeccion de Dependencias
        public ResponseVProduccion Create(RequestProduccion entity)
        {
            Produccion Produccion = _mapper.Map<Produccion>(entity);
            Produccion = _ProduccionRepository.Create(Produccion);
            ResponseVProduccion ResponseVProduccion = _mapper.Map<ResponseVProduccion>(Produccion);
            return ResponseVProduccion;

        }

        public List<ResponseVProduccion> CreateMultiple(List<RequestProduccion> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestProduccion> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseVProduccion> GetAll()
        {
            List<Produccion> Produccion = _ProduccionRepository.GetAll();
            List<ResponseVProduccion> ResponseVProduccion = _mapper.Map<List<ResponseVProduccion>>(Produccion);
            return ResponseVProduccion;
        }

        public ReponseFilterGeneric<ResponseVProduccion> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseVProduccion GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseVProduccion Update(RequestProduccion entity)
        {
            Produccion Produccion = _mapper.Map<Produccion>(entity);
            Produccion = _ProduccionRepository.Update(Produccion);
            ResponseVProduccion ResponseVProduccion = _mapper.Map<ResponseVProduccion>(Produccion);
            return ResponseVProduccion;
        }

        public List<ResponseVProduccion> UpdateMultiple(List<RequestProduccion> lista)
        {
            throw new NotImplementedException();
        }
    }
}
