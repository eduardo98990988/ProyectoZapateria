using DBModelZapateria;
using IRepository;
using IRepository.T_Produccion;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Produccion
{
    public class ProduccionRepository : CrudRepository<Produccion>, IProduccionRepository
    {
        public Produccion BuscarProduccion(string codigoProduccion)
        {
            Produccion? produccion = db.Produccions.Where(x => x.CodigoProduccion == codigoProduccion).FirstOrDefault();
            return produccion;
        }

        public ReponseFilterGeneric<Produccion> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
