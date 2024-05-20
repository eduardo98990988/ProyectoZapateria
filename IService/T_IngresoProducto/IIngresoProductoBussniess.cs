using RequestRespons.Request.T_IngresoProducto;
using RequestRespons.Response.T_IngresoProducto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_IngresoProducto
{
    public interface IIngresoProductoBussniess :ICrudBussniess<RequestIngresoProducto,ResponseVIngresoProducto>
    {
    }
}
