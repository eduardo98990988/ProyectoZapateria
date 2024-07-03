using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Proveedor
{
    public class ResponseVProveedor
    {
        [StringLength(100)]

        public string? NombreProveedor { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaEntrega { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaPedido { get; set; }

        public int Cantidad { get; set; }

        [Column(TypeName = "money")]
        public decimal PrecioUnitario { get; set; }

        [StringLength(50)]
        public string NombreMaterial { get; set; } = null!;

        [StringLength(15)]
        public string Telefono { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal? MontoTotal { get; set; }

        public int IdProvedor { get; set; }

        public int IdComprobante { get; set; }

        public int IdMaterial { get; set; }

        //[InverseProperty("IdProvedorNavigation")]
        //public virtual ICollection<ComprobanteProvedor> ComprobanteProvedors { get; set; } = new List<ComprobanteProvedor>();

        //[ForeignKey("IdPersona")]
        //[InverseProperty("Provedors")]
        //public virtual Persona IdPersonaNavigation { get; set; } = null!;
    }
}
