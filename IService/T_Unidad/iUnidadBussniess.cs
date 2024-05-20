using DBModelZapateria;
using RequestResponse.Request.T_Unidad;
using RequestResponse.Response.T_Unidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Unidad
{
    public interface iUnidadBussniess : ICrudBussniess<RequestUnidad,ResponseUnidad>
    {
       
    }
}
