using DBModelZapateria;
using IRepository.T_Rol;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Rol
{
    public class RolRepository : CrudRepository<Rol>, IRolRepository
    {
        public ReponseFilterGeneric<Rol> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
