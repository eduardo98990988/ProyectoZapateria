using RequestRespons.Request.T_DetalleCredito;
using RequestRespons.Response.T_DetalleCredito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_DetalleCredito
{
    public interface IDetalleCreditoBussniess : ICrudBussniess<RequestDetalleCredito,ResponseVDetalleCredito>
    {
    }
}
