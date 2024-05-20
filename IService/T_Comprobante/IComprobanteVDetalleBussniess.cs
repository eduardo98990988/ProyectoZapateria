using RequestRespons.Request.T_Comprobante;
using RequestRespons.Request.T_ComprobanteProveedor;
using RequestResponse.Response.T_Comprobante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Comprobante
{
    public interface IComprobanteVDetalleBussniess : ICrudBussniess<RequestVComprobanteProveedor, ResponseComprobanteDetalle>
    {
    }
}
