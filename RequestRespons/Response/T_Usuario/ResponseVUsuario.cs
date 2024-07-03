
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.T_Usuario
{
    public class ResponseVUsuario
    {
        [StringLength(30)]
        public string Usuario { get; set; } = null!;

        [StringLength(100)]
        public string Password { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [StringLength(50)]
        public string NombrePersona { get; set; } = null!;

        [StringLength(30)]
        public string TipoPersona { get; set; } = null!;

        [StringLength(50)]
        public string? Direccion { get; set; }

        [Column("IRol")]
        public int Irol { get; set; }

        [StringLength(25)]
        public string NombreRol { get; set; } = null!;

        public int IdUsuario { get; set; }


        //[InverseProperty("IdUsuarioNavigation")]
        //public virtual ICollection<Error> Errors { get; set; } = new List<Error>();

        //[InverseProperty("IdUsuarioNavigation")]
        //public virtual ICollection<Historial> Historials { get; set; } = new List<Historial>();

        //[ForeignKey("IdPersona")]
        //[InverseProperty("Usuarios")]
        //public virtual Persona IdPersonaNavigation { get; set; } = null!;

        //[ForeignKey("Irol")]
        //[InverseProperty("Usuarios")]
        //public virtual Rol IrolNavigation { get; set; } = null!;
    }
}
