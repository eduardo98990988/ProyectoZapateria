using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Orden
{
    public class RequestVOrden
    {
        [Key]
        public int IdOrden { get; set; }

        [StringLength(50)]
        public string CodigoOrden { get; set; } = null!;  //IDOrden

        [Column(TypeName = "datetime")]
        public DateTime FechaOrden { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaRequerido { get; set; }

        [StringLength(20)]
        public string EstadoOrden { get; set; } = null!;

        public int IdCliente { get; set; }

        public string NombreCliente { get; set; }
        public bool TipoOrden { get; set; }

        public int IdEmpleado { get; set; }

        public string NombreEmpleado { get; set; }
    }
}
