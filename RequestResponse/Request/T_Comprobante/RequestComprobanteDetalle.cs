using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Request.T_Comprobante
{
    public class RequestComprobanteDetalle
    {
        public int Cantidad { get; set; }

        [Key]
        public int IdComprobante { get; set; }

        [Key]
        public int IdMaterial { get; set; }

        [Column(TypeName = "money")]
        public decimal PrecioUnitario { get; set; }

        public int IdUnidad { get; set; }

        //[ForeignKey("IdComprobante")]
        //[InverseProperty("ComprobanteDetalles")]
        //public virtual ComprobanteProvedor IdComprobanteNavigation { get; set; } = null!;

        //[ForeignKey("IdMaterial")]
        //[InverseProperty("ComprobanteDetalles")]
        //public virtual Material IdMaterialNavigation { get; set; } = null!;

        //[ForeignKey("IdUnidad")]
        //[InverseProperty("ComprobanteDetalles")]
        //public virtual Unidad IdUnidadNavigation { get; set; } = null!;
    }
}
