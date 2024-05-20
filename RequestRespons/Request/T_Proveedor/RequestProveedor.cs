using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Proveedor
{
    public class RequestProveedor
    {

        [Key]
        public int IdProvedor { get; set; }

        public int IdPersona { get; set; }

        [StringLength(100)]
        public string? NombreProveedor { get; set; }

        //[InverseProperty("IdProvedorNavigation")]
        //public virtual ICollection<ComprobanteProvedor> ComprobanteProvedors { get; set; } = new List<ComprobanteProvedor>();

        //[ForeignKey("IdPersona")]
        //[InverseProperty("Provedors")]
        //public virtual Persona IdPersonaNavigation { get; set; } = null!;
    }
}
