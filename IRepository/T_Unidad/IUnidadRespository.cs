using DBModelZapateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.T_Unidad
{
    public interface IUnidadRespository : ICrudRepository<Unidad>
    {
        public Unidad BuscarUnidad(string nombreUnidad);
    }
}
