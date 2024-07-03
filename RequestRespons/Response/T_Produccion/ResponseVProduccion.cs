using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RequestResponse.Response.T_Produccion
{
    public class ResponseVProduccion
    {
        [Key]
        public int IdProduccion { get; set; }
        public int CantidadProduccion { get; set; }

        [StringLength(50)]
        public string? Descripcion { get; set; }

        public int Meta { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaInicio { get; set; }

        [StringLength(20)]
        public string EstadoProduccion { get; set; } = null!;

        [Column(TypeName = "datetime")]
        public DateTime? FechaFin { get; set; }

        [StringLength(40)]
        public string? NombreProd { get; set; }

        [StringLength(20)]
        public string? CodigoProd { get; set; }

        //[InverseProperty("IdProduccionNavigation")]
        //public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();

        //[ForeignKey("IdUnidad")]
        //[InverseProperty("Produccions")]
        //public virtual Unidad IdUnidadNavigation { get; set; } = null!;

        //[InverseProperty("IdProduccionNavigation")]
        //public virtual ICollection<IngresoProducto> IngresoProductos { get; set; } = new List<IngresoProducto>();

        //[InverseProperty("IdProduccionNavigation")]
        //public virtual ICollection<SalidaMaterial> SalidaMaterials { get; set; } = new List<SalidaMaterial>();
    }
}
