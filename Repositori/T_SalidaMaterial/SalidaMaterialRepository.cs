using DBModelZapateria;
using IRepository.T_SalidaMaterial;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_SalidaMaterial
{
    public class SalidaMaterialRepository : CrudRepository<SalidaMaterial>, ISalidaMaterialRepository
    {
        public ReponseFilterGeneric<SalidaMaterial> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
