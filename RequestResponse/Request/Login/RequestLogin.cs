using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Request.Login
{
    public class RequestLogin
    {
        public string Usuario { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
