using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Area
{
    public class ResponseArea
    {
        [Key]
        public int IdArea { get; set; }

        [StringLength(20)]
        public string? NombreArea { get; set; }

        [StringLength(50)]
        public string? DescripArea { get; set; }

        //[InverseProperty("IdAreaNavigation")]
        //public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();
    }
}
