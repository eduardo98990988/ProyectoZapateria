using DBModelZapateria;
using IRepository.T_Empleado;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Empleado
{
    public class EmpleadoRepository : CrudRepository<Empleado>, IEmpleadoRepository
    {
        public ReponseFilterGeneric<Empleado> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
