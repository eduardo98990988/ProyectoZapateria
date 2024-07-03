using DBModelZapateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.T_Orden
{
    public interface IOrdenRepository : ICrudRepository<Orden>
    {
        Orden buscarCodigoOrden(string codigoOrden);
        public List<VistOrden> GetAllVist();
    }
}
