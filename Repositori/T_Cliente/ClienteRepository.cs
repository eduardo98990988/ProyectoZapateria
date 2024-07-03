using DBModelZapateria;
using IRepository;
using IRepository.T_Cliente;
using Microsoft.EntityFrameworkCore;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Cliente
{
    public class ClienteRepository : CrudRepository<Cliente>, IClienteRepository
    {
        internal DbSet<VistCliente> dbset;
        public Cliente buscarCliente(string nombreCliente)
        {
            Cliente? cliente = db.Clientes.Where(x=>x.NombreCliente==nombreCliente).FirstOrDefault();
            return cliente;
        }

        public List<VistCliente> GetAllVist()
        {
            IQueryable<VistCliente> query = dbset;
            return query.ToList();
            
        }

        public ReponseFilterGeneric<Cliente> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
