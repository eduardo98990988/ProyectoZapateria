using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Credito
{
    public class RequestVCredito
    {
        [Key]
        public int IdCredito { get; set; }
        [Key]
        public int IdCliente { get; set; }
        [StringLength(50)]
        public string NombreCliente { get; set; } = null!; //IdCliente


        [StringLength(50)]
        public string CodigoOrden { get; set; } = null!;  //IDOrden

        [Column(TypeName = "money")]
        public decimal? MontoTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? MontoPagado { get; set; }

        [Column(TypeName = "money")]
        public decimal? MontoDeuda { get; set; }

        [StringLength(20)]
        public string? EstadoCredito { get; set; }


        [Column(TypeName = "money")]
        public decimal MontoAmortizacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaAmortizacion { get; set; }

        [StringLength(50)]
        public string? RelacionCliente { get; set; }

  
    }
}
