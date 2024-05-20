using RequestRespons.Request.T_DetalleOrden;
using RequestRespons.Response.T_DetalleOrden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_DetalleOrden
{
    public interface IDetalleOrdenBussniess : ICrudBussniess<RequestDetalleOrden,ResponseVDetalleOrden>
    {
    }
}
