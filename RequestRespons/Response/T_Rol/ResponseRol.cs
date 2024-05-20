using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestResponse.Response.T_Rol
{
    public class ResponseRol
    {
        [Key]
        [Column("IRol")]
        public int Irol { get; set; }

        [StringLength(25)]
        public string NombreRol { get; set; } = null!;

        public string? DescripRol { get; set; }

        //[InverseProperty("IrolNavigation")]
        //public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
