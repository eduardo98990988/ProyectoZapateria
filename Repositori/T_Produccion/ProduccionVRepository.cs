using DBModelZapateria;
using IRepository.T_Produccion;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Produccion
{
    public class ProduccionVRepository : CrudRepository<VistProduccion>, IProduccionVRepository
    {
        public ReponseFilterGeneric<VistProduccion> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
