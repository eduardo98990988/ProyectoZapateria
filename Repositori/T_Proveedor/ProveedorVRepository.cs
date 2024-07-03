using DBModelZapateria;
using IRepository.T_Proveedor;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Proveedor
{
    public class ProveedorVRepository : CrudRepository<VisProveedor>, IProveedorVRepository
    {
        public ReponseFilterGeneric<VisProveedor> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
