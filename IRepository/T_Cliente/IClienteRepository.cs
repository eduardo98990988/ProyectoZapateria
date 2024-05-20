using DBModelZapateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.T_Cliente
{
    public interface IClienteRepository : ICrudRepository<Cliente>
    {
        public Cliente buscarCliente(string nombreCliente);
    }
}
