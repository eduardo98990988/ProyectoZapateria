using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_SalidaMaterial
{
    public class ResponseVSalidaMaterial
    {
        public int Cantidad { get; set; }

        public int IdMaterial { get; set; }

        public int IdProduccion { get; set; }

        [StringLength(50)]
        public string NombreMaterial { get; set; } = null!;

        [StringLength(50)]
        public string? Estado { get; set; }

        public int Stock { get; set; }

        //[ForeignKey("IdMaterial")]
        //[InverseProperty("SalidaMaterials")]
        //public virtual Material IdMaterialNavigation { get; set; } = null!;

        //[ForeignKey("IdProduccion")]
        //[InverseProperty("SalidaMaterials")]
        //public virtual Produccion IdProduccionNavigation { get; set; } = null!;

        //[ForeignKey("IdUnidad")]
        //[InverseProperty("SalidaMaterials")]
        //public virtual Unidad IdUnidadNavigation { get; set; } = null!;
    }
}
