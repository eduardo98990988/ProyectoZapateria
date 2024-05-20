using DBModelZapateria;
using IRepository.T_IngresoProducto;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_IngresoProducto
{
    public class IngresoProductoRepository : CrudRepository<IngresoProducto>, IIngresoProductoRepository
    {
        public ReponseFilterGeneric<IngresoProducto> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
