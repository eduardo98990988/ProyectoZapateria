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
        [Key]
        public int IdCliente { get; set; }

        public int IdPersona { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaNacimiento { get; set; }

        public bool Estado { get; set; }

        //[InverseProperty("IdClienteNavigation")]
        //public virtual ICollection<Credito> Creditos { get; set; } = new List<Credito>();

        //[ForeignKey("IdPersona")]
        //[InverseProperty("Clientes")]
        //public virtual Persona IdPersonaNavigation { get; set; } = null!;

        //[InverseProperty("IdClienteNavigation")]
        //public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();
    }
}
