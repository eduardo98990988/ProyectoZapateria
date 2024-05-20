using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_DetalleCredito
{
    public class RequestDetalleCredito
    {
        [Column(TypeName = "money")]
        public decimal MontoAmortizacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaAmortizacion { get; set; }

        [Key]
        public int IdOrden { get; set; }

        [StringLength(50)]
        public string NombrePersona { get; set; } = null!;

        [StringLength(50)]
        public string? RelacionCliente { get; set; }

        [Key]
        public int IdCredito { get; set; }

        [Key]
        public int IdDetalleCredito { get; set; }

        //[ForeignKey("IdCredito")]
        //[InverseProperty("DetalleCredios")]
        //public virtual Credito IdCreditoNavigation { get; set; } = null!;

        //[ForeignKey("IdOrden")]
        //[InverseProperty("DetalleCredios")]
        //public virtual Orden IdOrdenNavigation { get; set; } = null!;
    }
}
