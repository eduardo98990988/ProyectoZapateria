using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_SalidaMaterial
{
    public class RequestSalidaMaterial
    {
        public int Cantidad { get; set; }

        [Key]
        public int IdProduccion { get; set; }

        [Key]
        public int IdMaterial { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaSalida { get; set; }

        public int IdUnidad { get; set; }

        [Key]
        public int IdSalidaMaterial { get; set; }

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
