using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_DetalleProduccion
{
    public class ResponseVDetalleProduccion
    {
        public int CantidadProduccion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }

        [Key]
        public int IdProduccion { get; set; }

        [Key]
        public int IdArea { get; set; }

        [StringLength(50)]
        public string? Descripcion { get; set; }

        [Key]
        public int IdEmpleado { get; set; }

        [Key]
        public int IdOrden { get; set; }

        public int IdUnidad { get; set; }

        [StringLength(20)]
        public string Estado { get; set; } = null!;

        [Column(TypeName = "datetime")]
        public DateTime? FechaFinalizado { get; set; }

        [Key]
        public int IdDetalleProduccion { get; set; }

        //[ForeignKey("IdArea")]
        //[InverseProperty("DetalleProduccions")]
        //public virtual Area IdAreaNavigation { get; set; } = null!;

        //[ForeignKey("IdEmpleado")]
        //[InverseProperty("DetalleProduccions")]
        //public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;

        //[ForeignKey("IdOrden")]
        //[InverseProperty("DetalleProduccions")]
        //public virtual Orden IdOrdenNavigation { get; set; } = null!;

        //[ForeignKey("IdProduccion")]
        //[InverseProperty("DetalleProduccions")]
        //public virtual Produccion IdProduccionNavigation { get; set; } = null!;

        //[ForeignKey("IdUnidad")]
        //[InverseProperty("DetalleProduccions")]
        //public virtual Unidad IdUnidadNavigation { get; set; } = null!;
    }
}
