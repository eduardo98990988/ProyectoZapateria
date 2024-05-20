using DBModelZapateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.T_Produccion
{
    public interface IProduccionRepository : ICrudRepository<Produccion>
    {
        public Produccion BuscarProduccion(string codigoProduccion);
    }
}
