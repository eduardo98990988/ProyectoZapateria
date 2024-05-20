using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.T_Unidad
{
    public class ResponseUnidad
    {
        [Key]
        public int IdUnidad { get; set; }

        [StringLength(30)]
        public string? NombreUnidad { get; set; }

        public string? Descriccion { get; set; }

        //[InverseProperty("IdUnidadNavigation")]
        //public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

        //[InverseProperty("IdUnidadNavigation")]
        //public virtual ICollection<DetalleOrden> DetalleOrdens { get; set; } = new List<DetalleOrden>();

        //[InverseProperty("IdUnidadNavigation")]
        //public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();

        //[InverseProperty("IdUnidadNavigation")]
        //public virtual ICollection<IngresoProducto> IngresoProductos { get; set; } = new List<IngresoProducto>();

        //[InverseProperty("IdUnidadNavigation")]
        //public virtual ICollection<Material> Materials { get; set; } = new List<Material>();

        //[InverseProperty("IdUnidadNavigation")]
        //public virtual ICollection<Produccion> Produccions { get; set; } = new List<Produccion>();

        //[InverseProperty("IdUnidadNavigation")]
        //public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

        //[InverseProperty("IdUnidadNavigation")]
        //public virtual ICollection<SalidaMaterial> SalidaMaterials { get; set; } = new List<SalidaMaterial>();
    }
}
