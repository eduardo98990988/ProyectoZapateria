using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Request.T_Material
{
    public class RequestVMaterial
    {
        [Key]
        public int IdMaterial { get; set; }

        [StringLength(50)]
        public string NombreMaterial { get; set; } = null!;
        [Required]
        public int Stock { get; set; }

        public string? DescripMaterial { get; set; }
        [Required]
        [StringLength(50)]
        public string? Marca { get; set; }

        [StringLength(50)]
        public string? Estado { get; set; }

        public string NombreUnidad { get; set; }
    }
}
