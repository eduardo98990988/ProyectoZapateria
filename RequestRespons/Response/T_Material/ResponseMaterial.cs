using RequestRespons.Response.T_Proveedor;
using RequestResponse.Response.T_Persona;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Material
{
    public class ResponseMaterial
    {
        public string message { get; set; } = null;
        public List<ResponseVMaterial> materials { get; set; } = new List<ResponseVMaterial>();
       
    }
}
