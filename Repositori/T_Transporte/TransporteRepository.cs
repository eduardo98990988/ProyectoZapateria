using DBModelZapateria;
using IRepository.T_Transporte;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Transporte
{
    public class TransporteRepository : CrudRepository<Trasporte>, ITransporteRepository
    {
        public ReponseFilterGeneric<Trasporte> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
