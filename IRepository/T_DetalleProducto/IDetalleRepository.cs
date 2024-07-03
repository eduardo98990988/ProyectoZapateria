using DBModelZapateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.T_DetalleProducto
{
    public interface IDetalleProductoRepository : ICrudRepository<DetalleProducto>
    {
        public DetalleProducto buscarDetalle(int id);
    }
}
