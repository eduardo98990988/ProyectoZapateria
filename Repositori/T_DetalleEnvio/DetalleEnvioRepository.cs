using DBModelZapateria;
using IRepository.T_DetalleEnvio;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_DetalleEnvio
{
    public class DetalleEnvioRepository : CrudRepository<DetalleEnvio>, IDetalleEnvioRepository
    {
        public ReponseFilterGeneric<DetalleEnvio> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
