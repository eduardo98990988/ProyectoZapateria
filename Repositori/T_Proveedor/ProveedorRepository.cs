using DBModelZapateria;
using IRepository.T_Proveedor;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Proveedor
{
    public class ProveedorRepository : CrudRepository<Provedor>, IProveedorRepository
    {
        public Provedor buscarProveedor(string nombreProveedor)
        {
            Provedor? proveedor = db.Provedors.Where(x=>x.NombreProveedor==nombreProveedor).FirstOrDefault();
            return proveedor;
        }

        public ReponseFilterGeneric<Provedor> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
    }
}
