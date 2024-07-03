﻿using DBModelZapateria;
using RequestResponse.Request.T_Usuario;
using RequestResponse.Response.T_Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBussniess.T_Usuario
{
    public interface IUsuarioBussniess : ICrudBussniess<RequestUsuario,ResponseVUsuario>
    {
        public List<VisUsuario> GetAllVist();
    }
}
