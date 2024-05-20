using DBModelZapateria;
using IRepository.T_Persona;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Persona
{
    public class PersonaRepository : CrudRepository<Persona>, IPersonaRepository
    {
        public ReponseFilterGeneric<Persona> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
