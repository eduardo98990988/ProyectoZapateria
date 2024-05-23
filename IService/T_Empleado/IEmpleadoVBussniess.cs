using RequestRespons.Request.T_Empleado;
using RequestResponse.Response.T_Empleado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Empleado
{
    public interface IEmpleadoVBussniess : ICrudBussniess<RequestVEmpleado,ResponseEmpleado>
    {
    }
}
