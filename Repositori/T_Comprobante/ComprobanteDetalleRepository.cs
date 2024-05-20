using DBModelZapateria;
using IRepository;
using IRepository.T_Comprobante;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Comprobante
{
    public class ComprobanteDetalleRepository : CrudRepository<ComprobanteDetalle>, IComprobanteDetalleRepository
    {
        public ReponseFilterGeneric<ComprobanteDetalle> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
