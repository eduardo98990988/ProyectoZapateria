using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Orden
{
    public class RequestOrden
    {
        [Key]
        public int IdOrden { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaOrden { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaRequerido { get; set; }

        [StringLength(20)]
        public string EstadoOrden { get; set; } = null!;

        public int IdCliente { get; set; }

        public bool TipoOrden { get; set; }

        public int IdEmpleado { get; set; }

        //[InverseProperty("IdOrdenNavigation")]
        //public virtual ICollection<DetalleCredio> DetalleCredios { get; set; } = new List<DetalleCredio>();

        //[InverseProperty("IdOrdenNavigation")]
        //public virtual ICollection<DetalleEnvio> DetalleEnvios { get; set; } = new List<DetalleEnvio>();

        //[InverseProperty("IdOrdenNavigation")]
        //public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

        //[InverseProperty("IdOrdenNavigation")]
        //public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();

        //[ForeignKey("IdCliente")]
        //[InverseProperty("Ordens")]
        //public virtual Cliente IdClienteNavigation { get; set; } = null!;

        //[ForeignKey("IdEmpleado")]
        //[InverseProperty("Ordens")]
        //public virtual Empleado IdEmpleadoNavigation { get; set; } = null!;
    }
}
