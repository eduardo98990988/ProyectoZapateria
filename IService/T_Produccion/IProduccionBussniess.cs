using RequestResponse.Request.T_Produccion;
using RequestResponse.Response.T_Produccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Produccion
{
    public interface IProduccionBussniess : ICrudBussniess<RequestProduccion,ResponseVProduccion>
    {
    }
}
