using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.T_Empleado
{
    public class ResponseVEmpleado
    {
        [StringLength(30)]
        public string Usuario { get; set; } = null!;

        public int IdUsuario { get; set; }

        [Column("IRol")]
        public int Irol { get; set; }

        [StringLength(25)]
        public string NombreRol { get; set; } = null!;

        public decimal Salario { get; set; }

        public int IdEmpleado { get; set; }
        [StringLength(50)]
        public string NombrePersona { get; set; } = null!;

        [StringLength(30)]
        public string? ApellidoEmp { get; set; }

        [StringLength(15)]
        public string TipoDocumento { get; set; } = null!;

        [StringLength(20)]
        public string NumeroDocumento { get; set; } = null!;

        [StringLength(15)]
        public string Telefono { get; set; } = null!;

        //[InverseProperty("IdEmpleadoNavigation")]
        //public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();

        //[ForeignKey("IdPersona")]
        //[InverseProperty("Empleados")]
        //public virtual Persona IdPersonaNavigation { get; set; } = null!;

        //[InverseProperty("IdEmpleadoNavigation")]
        //public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();
    }
}
