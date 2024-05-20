using DBModelZapateria;
using IRepository.T_Area;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Area
{
    public class AreaRepository : CrudRepository<Area>, IAreaRepository
    {
        public ReponseFilterGeneric<Area> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
