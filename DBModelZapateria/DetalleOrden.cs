using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[PrimaryKey("IdDetalleOrden", "IdOrden", "IdProducto", "Talla")]
[Table("DetalleOrden")]
public partial class DetalleOrden
{
    [Column(TypeName = "money")]
    public decimal PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    [Key]
    public int IdOrden { get; set; }

    [Key]
    [StringLength(5)]
    public string Talla { get; set; } = null!;

    [Key]
    public int IdProducto { get; set; }

    public int IdUnidad { get; set; }

    [Key]
    public int IdDetalleOrden { get; set; }

    [ForeignKey("IdOrden")]
    [InverseProperty("DetalleOrdens")]
    public virtual Orden IdOrdenNavigation { get; set; } = null!;

    [ForeignKey("IdProducto")]
    [InverseProperty("DetalleOrdens")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdUnidad")]
    [InverseProperty("DetalleOrdens")]
    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
