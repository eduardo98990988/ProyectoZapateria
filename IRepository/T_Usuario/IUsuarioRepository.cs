﻿using DBModelZapateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository.T_Usuario
{
    public interface IUsuarioRepository : ICrudRepository<Usuario>
    {
        public VisUsuario ObtenerUsuario(string username);
        public List<VisUsuario> GetAllVist();
    }
}
