using DBModelZapateria;
using IRepository.T_DetalleOrden;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_DetalleOrden
{
    public class DetalleOrdenRepository : CrudRepository<DetalleOrden>, IDetalleOrdenRepository
    {
        public ReponseFilterGeneric<DetalleOrden> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
        //ejecucion de los pryectos actualizanfo 



    }
}
