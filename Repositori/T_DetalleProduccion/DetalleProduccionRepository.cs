using DBModelZapateria;
using IRepository.T_DetalleProduccion;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_DetalleProduccion
{
    public class DetalleProduccionRepository : CrudRepository<DetalleProduccion>, IDetalleProduccionRepository
    {
        public ReponseFilterGeneric<DetalleProduccion> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
