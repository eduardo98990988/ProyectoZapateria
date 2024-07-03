using DBModelZapateria;
using IRepository.T_DetalleProducto;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_DetalleProducto
{
    public class DetalleRepository : CrudRepository<DetalleProducto>, IDetalleProductoRepository
    {
        public DetalleProducto buscarDetalle(int id)
        {
            DetalleProducto producto = db.DetalleProductos.Where(X=>X.IdProducto==id).FirstOrDefault();
            return producto;

        }

        public ReponseFilterGeneric<DetalleProducto> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
