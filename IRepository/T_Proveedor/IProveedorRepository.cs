using DBModelZapateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.T_Proveedor
{
    public interface IProveedorRepository : ICrudRepository<Provedor>
    {
        Provedor buscarProveedor(string nombreProveedor);
    }
}
