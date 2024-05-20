using DBModelZapateria;
using IRepository.T_Unidad;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Unidad
{
    public class UnidadRepository : CrudRepository<Unidad>, IUnidadRespository
    {
        public Unidad BuscarUnidad(string nombreUnidad)
        {
            Unidad? unidad = db.Unidads.Where(x=>x.NombreUnidad ==nombreUnidad).FirstOrDefault();
            return unidad;

        }

        public ReponseFilterGeneric<Unidad> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
