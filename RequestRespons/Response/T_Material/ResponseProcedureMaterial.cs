using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Material
{
    public class ResponseProcedureMaterial
    {
        [Key]
        public int IdMaterial { get; set; }

        [StringLength(50)]
        public string NombreMaterial { get; set; } = null!;

        public int Stock { get; set; }


        [StringLength(50)]
        public string? Estado { get; set; }
    }
}
