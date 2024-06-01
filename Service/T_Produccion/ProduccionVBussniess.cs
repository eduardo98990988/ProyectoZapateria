using IBussniess.T_Produccion;
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
    public class ProduccionVBussniess : IProduccionBussniess
    {

        public ResponseVProduccion Create(RequestProduccion entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<ResponseVProduccion> UpdateMultiple(List<RequestProduccion> lista)
        {
            throw new NotImplementedException();
        }
    }
}
