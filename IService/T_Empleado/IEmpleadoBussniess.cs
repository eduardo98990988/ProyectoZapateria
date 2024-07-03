using DBModelZapateria;
using RequestResponse.Request.T_Empleado;
using RequestResponse.Response.T_Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Empleado
{
    public interface IEmpleadoBussniess : ICrudBussniess<RequestEmpleado,ResponseVEmpleado>
    {
        public List<VistEmpleado> GetAllVist();
    }
}
