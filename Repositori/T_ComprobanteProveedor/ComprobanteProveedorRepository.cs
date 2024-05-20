using DBModelZapateria;
using IRepository.T_ComprobanteProveedor;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_ComprobanteProveedor
{
    public class ComprobanteProveedorRepository : CrudRepository<ComprobanteProvedor>, IComprobanteProveedorRepository
    {
        public ReponseFilterGeneric<ComprobanteProvedor> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
