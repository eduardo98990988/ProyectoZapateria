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
        public Producto BsucarProducto(string nombreProducto)
        {
            Producto? producto = db.Productos.Where(x=>x.NombreProd==nombreProducto).FirstOrDefault();
            return producto;
            
           
        }

        public ReponseFilterGeneric<Producto> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
