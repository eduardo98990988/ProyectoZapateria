using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRespons.Response.T_Modelo
{
    public class ResponseModelo
    {
        [Key]
        public int IdModelo { get; set; }

        [StringLength(30)]
        public string? NombreModelo { get; set; }

        [StringLength(10)]
        public string? CodigoModelo { get; set; }

        [StringLength(100)]
        public string? DescripModelo { get; set; }

        [StringLength(100)]
        public string? ImageModelo { get; set; }

        //[InverseProperty("IdModeloNavigation")]
        //public virtual ICollection<DetalleProducto> DetalleProductos { get; set; } = new List<DetalleProducto>();
    }
}
