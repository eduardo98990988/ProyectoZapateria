﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Proveedor
{
    public class RequestVProveedor
    {
        [Key]
        public int IdProvedor { get; set; }

        [StringLength(100)]
        public string? NombreProveedor { get; set; }
        [Key]
        public int IdPersona { get; set; }

        [StringLength(50)]
        public string NombrePersona { get; set; } = null!;

        [StringLength(30)]
        public string TipoPersona { get; set; } = null!;

        [StringLength(15)]
        public string TipoDocumento { get; set; } = null!;

        [StringLength(20)]
        public string NumeroDocumento { get; set; } = null!;

        [StringLength(15)]
        public string Telefono { get; set; } = null!;

        [StringLength(10)]
        public string? CodigoUbigeo { get; set; }

        [StringLength(50)]
        public string? Direccion { get; set; }
    }
}
