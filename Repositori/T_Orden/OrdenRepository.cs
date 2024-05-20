using DBModelZapateria;
using IRepository.T_Orden;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Orden
{
    public class OrdenRepository : CrudRepository<Orden>, IOrdenRepository
    {
        public Orden buscarCodigoOrden(string codigoOrden)
        {
            Orden? orden = db.Ordens.Where(x=>x.CodigoOrden== codigoOrden).FirstOrDefault();
            return orden;
        }

        public ReponseFilterGeneric<Orden> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
