using RequestRespons.Request.T_Producto;
using RequestRespons.Response.T_Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Producto
{
    public interface IProductoBussniess : ICrudBussniess<RequestProducto,ResponseVProducto>
    {
    }
}
