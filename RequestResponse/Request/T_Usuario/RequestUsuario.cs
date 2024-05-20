using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestResponse.Request.T_Persona;

namespace RequestResponse.Request.T_Usuario
{
    public class RequestUsuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Column("Usuario")]
        [StringLength(30)]
        public string Usuario1 { get; set; } = null!;

        [StringLength(100)]
        public string Password { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        public int IdPersona { get; set; }

        [Column("IRol")]
        public int Irol { get; set; }

        public bool Estado { get; set; }

        public RequestPersona? persona { get; set; } = null;

        //[StringLength(100)]
        //public string? Fotografia { get; set; }
    }
}
