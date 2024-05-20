using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_DetalleEnvio
{
    public class ResponseVDetalleEnvio
    {
        [Key]
        public int IdTransporte { get; set; }

        [Key]
        public int IdOrden { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaEnvio { get; set; }

        [StringLength(10)]
        public string? CodigoUbigeo { get; set; }

        [StringLength(50)]
        public string? Direccion { get; set; }

        [Key]
        [Column("idDetalleEnvio")]
        public int IdDetalleEnvio { get; set; }

        //[ForeignKey("IdOrden")]
        //[InverseProperty("DetalleEnvios")]
        //public virtual Orden IdOrdenNavigation { get; set; } = null!;

        //[ForeignKey("IdTransporte")]
        //[InverseProperty("DetalleEnvios")]
        //public virtual Trasporte IdTransporteNavigation { get; set; } = null!;
    }
}
