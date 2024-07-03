using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Empleado
{
    public class RequestVEmpleado
    {
        [Key]
        public int IdEmpleado { get; set; }

        [StringLength(30)]
        public string? ApellidoEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal Salario { get; set; }

        [StringLength(50)]
        public string NombrePersona { get; set; } = null!;

        public string Usuario1 { get; set; } = null!;

        [StringLength(100)]
        public string Password { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        //public bool Estado { get; set; }

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

        [StringLength(100)]
        public string? ImagenEmpleado { get; set; }
    }
}
