using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Cliente
{
    public class ResponseVCliente
    {
        public int IdCliente { get; set; }

        [Column("IRol")]
        public int Irol { get; set; }

        public int IdUsuario { get; set; }

        public int IdPersona { get; set; }

        [StringLength(25)]
        public string NombreRol { get; set; } = null!;

        [StringLength(30)]
        public string Usuario { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [StringLength(50)]

        public string? NombreCliente { get; set; }

        [StringLength(15)]
        public string Telefono { get; set; } = null!;
    }

    //[InverseProperty("IdClienteNavigation")]
    //public virtual ICollection<Credito> Creditos { get; set; } = new List<Credito>();

    //[ForeignKey("IdPersona")]
    //[InverseProperty("Clientes")]
    //public virtual Persona IdPersonaNavigation { get; set; } = null!;

    //[InverseProperty("IdClienteNavigation")]
    //public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();

}
