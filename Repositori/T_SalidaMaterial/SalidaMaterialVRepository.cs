using DBModelZapateria;
using IRepository;
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
    public class SalidaMaterialVRepository : CrudRepository<VistSalidaMaterial>, ISalidaMaterialVRepository
    {
        public ReponseFilterGeneric<VistSalidaMaterial> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
