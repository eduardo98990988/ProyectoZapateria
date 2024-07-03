using DBModelZapateria;
using IRepository.T_Cliente;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Cliente
{
    public class ClienteVRepository : CrudRepository<VistCliente>, IClienteVRepository
    {
        public ReponseFilterGeneric<VistCliente> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
