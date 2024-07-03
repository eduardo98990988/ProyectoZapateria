using DBModelZapateria;
using RequestRespons.Request.T_Cliente;
using RequestRespons.Response.T_Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Cliente
{
    public interface IClienteBussniess : ICrudBussniess<RequestCliente,ResponseVCliente>
    {
        public List<VistCliente> GetAllVist();
    }
}
