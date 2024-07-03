﻿using DBModelZapateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.T_Empleado
{
    public interface  IEmpleadoRepository : ICrudRepository<Empleado>
    {
        public Empleado BuscarEmpleado(string nombreEmpleado);
        public List<VistEmpleado> GetAllVist();
    }
}
