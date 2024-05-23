using RequestRespons.Request.T_Material;
using RequestRespons.Request.T_SalidaMaterial;
using RequestRespons.Response.T_Material;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Material
{
    public interface IMaterialVBussniess : ICrudBussniess<RequestVMaterial,ResponseMaterial>
    {
    }
}
