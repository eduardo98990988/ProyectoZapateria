using RequestRespons.Response.T_Proveedor;
using RequestResponse.Response.T_Persona;
using RequestResponse.Response.T_Produccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_SalidaMaterial
{
    public class ResponseSalidaMaterial
    {
        public string message { get; set; } = null;
        public List<ResponseVSalidaMaterial> salidaMaterials { get; set; } = new List<ResponseVSalidaMaterial>();
        public ResponseProduccion produccion { get; set; } = new ResponseProduccion();

    }
}
