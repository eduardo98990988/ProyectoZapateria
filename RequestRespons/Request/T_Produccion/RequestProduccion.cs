using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Request.T_Produccion
{
    public class RequestProduccion
    {
        [Key]
        public int IdProduccion { get; set; }
        [StringLength(20)]

        public string CodigoProduccion { get; set; } = null!;
        public int Meta { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime FechaInicio { get; set; }

        [StringLength(20)]
        public string EstadoProduccion { get; set; } = null!;

        public int? CantidadFaltante { get; set; }

        public int IdUnidad { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaFin { get; set; }

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
