using DBModelZapateria;
using IRepository.T_Producto;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Producto
{
    public class ProductoRepository : CrudRepository<Producto>, IProductoRepository
    {
        public ReponseFilterGeneric<Producto> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
