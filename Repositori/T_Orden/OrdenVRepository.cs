using DBModelZapateria;
using IRepository.T_Orden;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Orden
{
    public class OrdenVRepository : CrudRepository<VistOrden>, IOrdenVRepository
    {
        public ReponseFilterGeneric<VistOrden> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
