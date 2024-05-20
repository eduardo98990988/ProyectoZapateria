using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_ComprobanteProveedor
{
    public class RequestVComprobanteProveedor
    {
        public int Cantidad { get; set; }

        [Key]
        public int IdComprobante { get; set; }

        [Key]
        public int IdUnidad { get; set; }

        [Key]
        public int IdMaterial { get; set; }

        [StringLength(50)]
        public string NombreMaterial { get; set; } = null!;


        [StringLength(30)]
        public string? NombreUnidad { get; set; }

        [Column(TypeName = "money")]
        public decimal PrecioUnitario { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaEntrega { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaPedido { get; set; }

        [Column(TypeName = "money")]
        public decimal CosteTransporte { get; set; }

      

        [StringLength(20)]
        public string TipoComprobante { get; set; } = null!;

        [StringLength(20)]
        public string CodigoComprobante { get; set; } = null!;

        public int IdProvedor { get; set; }

        [Column(TypeName = "money")]
        public decimal? MontoTotal { get; set; }

        public int? CantidadTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? SubTotal { get; set; }
    }
}
