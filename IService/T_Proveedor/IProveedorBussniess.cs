using RequestRespons.Request.T_Proveedor;
using RequestRespons.Response.T_Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Proveedor
{
    public interface IProveedorBussniess : ICrudBussniess<RequestProveedor,ResponseVProveedor>
    {
    }
}
