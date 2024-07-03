using DBModelZapateria;
using IRepository.T_Usuario;
using Microsoft.EntityFrameworkCore;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Usuario
{
    public class UsuarioRepository : CrudRepository<Usuario>, IUsuarioRepository
    {
        internal DbSet<VisUsuario> dbset;
        public List<VisUsuario> GetAllVist()
        {
            IQueryable<VisUsuario> query = dbset;
            return query.ToList();
        }

        public ReponseFilterGeneric<Usuario> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }

        public VisUsuario ObtenerUsuario(string username)
        {
            VisUsuario? usuario = db.VisUsuarios.Where(x=>x.Usuario==username).FirstOrDefault();
            return usuario; 
        }
    }
}
