using DBModelZapateria;
using IRepository.T_DetalleCredito;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_DetalleCredito
{
    public class DetalleCreditoRepository : CrudRepository<DetalleCredio>, IDetalleCreditoRepository
    {
        public ReponseFilterGeneric<DetalleCredio> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
