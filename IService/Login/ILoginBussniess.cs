using RequestResponse.Request.Login;
using RequestResponse.Response.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.Login
{
    public interface ILoginBussniess
    {
        ResponseLogin Login (RequestLogin login);
    }
}
