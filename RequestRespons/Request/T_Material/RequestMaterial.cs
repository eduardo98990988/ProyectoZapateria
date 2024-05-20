using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Material
{
    public class RequestMaterial
    {
        [Key]
        public int IdMaterial { get; set; }

        [StringLength(50)]
        public string NombreMaterial { get; set; } = null!;

        public int Stock { get; set; }

        public string? DescripMaterial { get; set; }

        [StringLength(50)]
        public string? Marca { get; set; }

        [StringLength(50)]
        public string? Estado { get; set; }

        public int IdUnidad { get; set; }

        //[InverseProperty("IdMaterialNavigation")]
        //public virtual ICollection<ComprobanteDetalle> ComprobanteDetalles { get; set; } = new List<ComprobanteDetalle>();

        //[ForeignKey("IdUnidad")]
        //[InverseProperty("Materials")]
        //public virtual Unidad IdUnidadNavigation { get; set; } = null!;

        //[InverseProperty("IdMaterialNavigation")]
        //public virtual ICollection<SalidaMaterial> SalidaMaterials { get; set; } = new List<SalidaMaterial>();
    }
}
