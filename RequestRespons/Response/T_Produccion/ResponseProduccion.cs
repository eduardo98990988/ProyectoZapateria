using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.T_Produccion
{
    public class ResponseProduccion
    {
        public string message { get; set; } = "";

        public List<ResponseVProduccion> produccions { get; set;} = new List<ResponseVProduccion>();

    }
}
