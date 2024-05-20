using RequestRespons.Request.T_DetalleEnvio;
using RequestRespons.Response.T_DetalleEnvio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_DetalleEnvio
{
    public interface IDetalleEnvioBussniess : ICrudBussniess<RequestDetalleEnvio,ResponseVDetalleEnvio>
    {
    }
}
