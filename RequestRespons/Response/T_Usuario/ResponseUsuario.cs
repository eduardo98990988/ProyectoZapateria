using RequestResponse.Response.T_Persona;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.T_Usuario
{
    public class ResponseUsuario
    {
        public string message { get; set; } = "";
        public string token { get; set; } = "";
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
        //public ResponsePersona? Persona { get; set; } = null;
        [Key]
        public int IdUsuario { get; set; }

        [Column("Usuario")]
        [StringLength(30)]
        public string Usuario1 { get; set; } = null!;

        [StringLength(100)]
        public string Password { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [Column("IRol")]

        public int Irol { get; set; }

        public string NombreRol { get; set; } = null!;

        public bool Estado { get; set; }

        [StringLength(100)]
        public string? Fotografia { get; set; }
        //public ResponseVUsuario? VWUsuario { get; set; } = null;
        public List<ResponseVUsuario> usuarios { get; set; } = new List<ResponseVUsuario>();
    }
}
