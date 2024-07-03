using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_DetalleProducto
{
    public class ResponseVDetalleProducto
    {
        [Key]
        public int IdModelo { get; set; }

        [Key]
        public int IdProducto { get; set; }

        [StringLength(15)]
        public string? Color { get; set; }

        [StringLength(20)]
        public string? Categoria { get; set; }

        [Key]
        [StringLength(5)]
        public string Talla { get; set; } = null!;


        public string? Material { get; set; }

    
        public string? Descripcion { get; set; }

        [Key]
        public int IdDetalleProducto { get; set; }


    }
}
