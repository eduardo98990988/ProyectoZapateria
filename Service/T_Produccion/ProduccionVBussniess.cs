using AutoMapper;
using DBModelZapateria;
using IBussniess;
using IBussniess.T_Produccion;
using IRepository.T_Produccion;
using Repositori.T_Produccion;
using RequestRespons.Request.T_Produccion;
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
    public class ProduccionVBussniess : IProduccionVBussniess
    {
        #region Inyeccion de Dependencias
        private readonly IProduccionVRepository _produccionVRepsoitory;
        private readonly IMapper _mapper;

        public ProduccionVBussniess (IMapper mapper)
        {
            _mapper = mapper;
            _produccionVRepsoitory = new ProduccionVRepository();
        }

        public ResponseProduccion Create(RequestVProduccion entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseProduccion> CreateMultiple(List<RequestVProduccion> lista)
        {
            throw new NotImplementedException();
        }

        public int Delete(object id)
        {
            throw new NotImplementedException();
        }

        public int DeleteMultiple(List<RequestVProduccion> lista)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<ResponseProduccion> GetAll()
        {
            List<ResponseProduccion> responseProduccions = new List<ResponseProduccion>();
            ResponseProduccion response = new ResponseProduccion();
            response.produccions = new List<ResponseVProduccion>();

            List<VistProduccion> vistProduccions = _produccionVRepsoitory.GetAll();
            response.produccions = _mapper.Map<List<ResponseVProduccion>>(vistProduccions);
            response.message = "Lista de Producciones de la empresa";
            responseProduccions.Add(response);
            return responseProduccions;
        }

        public ReponseFilterGeneric<ResponseProduccion> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public ResponseProduccion GetById(object id)
        {
            throw new NotImplementedException();
        }

        public ResponseProduccion Update(RequestVProduccion entity)
        {
            throw new NotImplementedException();
        }

        public List<ResponseProduccion> UpdateMultiple(List<RequestVProduccion> lista)
        {
            throw new NotImplementedException();
        }
        #endregion Inyeccion de Dependencias



    }
}
