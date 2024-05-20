using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[PrimaryKey("IdDetalleProducto", "IdModelo", "IdProducto", "Talla")]
[Table("DetalleProducto")]
public partial class DetalleProducto
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

    [StringLength(18)]
    [Unicode(false)]
    public string? Material { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Key]
    public int IdDetalleProducto { get; set; }

    [ForeignKey("IdModelo")]
    [InverseProperty("DetalleProductos")]
    public virtual Modelo IdModeloNavigation { get; set; } = null!;

    [ForeignKey("IdProducto")]
    [InverseProperty("DetalleProductos")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;
}
