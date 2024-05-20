using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.T_Empleado
{
    public class ResponseEmpleado
    {
        public string message { get; set; } = "";
        public List<ResponseVEmpleado> empleado { get; set; } = new List<ResponseVEmpleado>();


    }
}
