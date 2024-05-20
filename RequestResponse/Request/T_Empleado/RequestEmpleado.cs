using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Request.T_Empleado
{
    public class RequestEmpleado
    {
        [Key]
        public int IdEmpleado { get; set; }

        [StringLength(30)]
        public string? ApellidoEmp { get; set; }

        [Column(TypeName = "money")]
        public decimal Salario { get; set; }

        public int IdPersona { get; set; }

        [StringLength(100)]
        public string? ImagenEmpleado { get; set; }

        //[InverseProperty("IdEmpleadoNavigation")]
        //public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();

        //[ForeignKey("IdPersona")]
        //[InverseProperty("Empleados")]
        //public virtual Persona IdPersonaNavigation { get; set; } = null!;

        //[InverseProperty("IdEmpleadoNavigation")]
        //public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();
    }
}
