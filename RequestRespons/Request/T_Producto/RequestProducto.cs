using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Producto
{
    public class RequestProducto
    {
        [Key]
        public int IdProducto { get; set; }

        [StringLength(40)]
        public string? NombreProd { get; set; }

        [StringLength(20)]
        public string? CodigoProd { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrecioUnitario { get; set; }

        public int Stock { get; set; }

        public bool EstadoProducto { get; set; }

        public int IdUnidad { get; set; }

        [StringLength(100)]
        public string? Fotografia { get; set; }

        //[InverseProperty("IdProductoNavigation")]
        //public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

        //[InverseProperty("IdProductoNavigation")]
        //public virtual ICollection<DetalleProducto> DetalleProductos { get; set; } = new List<DetalleProducto>();

        //[ForeignKey("IdUnidad")]
        //[InverseProperty("Productos")]
        //public virtual Unidad IdUnidadNavigation { get; set; } = null!;

        //[InverseProperty("IdProductoNavigation")]
        //public virtual ICollection<IngresoProducto> IngresoProductos { get; set; } = new List<IngresoProducto>();
    }
}
