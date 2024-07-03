using DBModelZapateria;
using IRepository;
using IRepository.T_Usuario;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Usuario
{
    public class UsuarioVRepository : CrudRepository<VisUsuario>, IUsuarioVRepository
    {
        public ReponseFilterGeneric<VisUsuario> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
