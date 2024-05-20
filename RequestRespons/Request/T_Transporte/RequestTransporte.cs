using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Transporte
{
    public class RequestTransporte
    {
        [Key]
        public int IdTransporte { get; set; }

        [StringLength(20)]
        public string? NumeroPlaca { get; set; }

        [StringLength(50)]
        public string? LicenciaConductor { get; set; }

        [StringLength(50)]
        public string? TipoAutomovil { get; set; }

        public int IdPersona { get; set; }

        //[InverseProperty("IdTransporteNavigation")]
        //public virtual ICollection<DetalleEnvio> DetalleEnvios { get; set; } = new List<DetalleEnvio>();

        //[ForeignKey("IdPersona")]
        //[InverseProperty("Trasportes")]
        //public virtual Persona IdPersonaNavigation { get; set; } = null!;
    }
}
