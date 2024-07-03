using DBModelZapateria;
using IRepository.T_Orden;
using Microsoft.EntityFrameworkCore;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Orden
{
    public class OrdenRepository : CrudRepository<Orden>, IOrdenRepository
    {
        internal DbSet<VistOrden> dbset;
        public Orden buscarCodigoOrden(string codigoOrden)
        {
            Orden? orden = db.Ordens.Where(x=>x.CodigoOrden== codigoOrden).FirstOrDefault();
            return orden;
        }

        public List<VistOrden> GetAllVist()
        {
            IQueryable<VistOrden> query = dbset;
            return query.ToList();
        }

        public ReponseFilterGeneric<Orden> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
