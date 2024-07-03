using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Orden
{
    public class ResponseVOrden
    {
        public int IdOrden { get; set; }

        public int IdProducto { get; set; }

        public string? CodigoOrden { get; set; }

        [StringLength(40)]
        public string? NombreProd { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FechaOrden { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaRequerido { get; set; }

        [StringLength(20)]
        public string EstadoOrden { get; set; } = null!;

        public int IdCliente { get; set; }

        [StringLength(50)]

        public string? NombreCliente { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrecioUnitario { get; set; }
        public double? MontoTotal { get; set; }

        public int Cantidad { get; set; }

        [StringLength(20)]
        public string? Categoria { get; set; }


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
