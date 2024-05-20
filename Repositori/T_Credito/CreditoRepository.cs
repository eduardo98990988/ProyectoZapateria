using DBModelZapateria;
using IRepository.T_Credito;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Credito
{
    public class CreditoRepository : CrudRepository<Credito>, ICreditoRepository
    {
        public ReponseFilterGeneric<Credito> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
