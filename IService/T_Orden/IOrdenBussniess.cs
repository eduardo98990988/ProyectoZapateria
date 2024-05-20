using RequestRespons.Request.T_Orden;
using RequestRespons.Response.T_Orden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Orden
{
    public interface IOrdenBussniess : ICrudBussniess<RequestOrden,ResponseVOrden>
    {
    }
}
