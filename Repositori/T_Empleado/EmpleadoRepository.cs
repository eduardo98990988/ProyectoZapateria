using DBModelZapateria;
using IRepository.T_Empleado;
using Microsoft.EntityFrameworkCore;
using RequestResponse.Request;
using RequestResponse.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositori.T_Empleado
{
    public class EmpleadoRepository : CrudRepository<Empleado>, IEmpleadoRepository
    {
        internal DbSet<VistEmpleado> dbset;
        public Empleado BuscarEmpleado(string nombreEmpleado)
        {
            Empleado empleado = db.Empleados.Where(x=>x.ApellidoEmp==nombreEmpleado).FirstOrDefault();
            return empleado;
        }

        public List<VistEmpleado> GetAllVist()
        {
            IQueryable<VistEmpleado> query = dbset;
            return query.ToList();
          
        }

        public ReponseFilterGeneric<Empleado> GetByFilter(RequestFilterGeneric request)
        {
            throw new NotImplementedException();
        }
       
    }
}
