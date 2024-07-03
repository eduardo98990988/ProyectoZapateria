using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Cliente
{
    public class RequestVCliente
    {
        [Key]
        public int IdCliente { get; set; }

        public int IdPersona { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaNacimiento { get; set; } 

        //public bool Estado { get; set; }
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
