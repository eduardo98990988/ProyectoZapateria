using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[PrimaryKey("IdIngresoProducto", "IdProduccion", "IdProducto")]
[Table("IngresoProducto")]
public partial class IngresoProducto
{
    [Key]
    public int IdProduccion { get; set; }

    [Key]
    public int IdProducto { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaIngreso { get; set; }

    public int IdUnidad { get; set; }

    [Key]
    public int IdIngresoProducto { get; set; }

    [ForeignKey("IdProduccion")]
    [InverseProperty("IngresoProductos")]
    public virtual Produccion IdProduccionNavigation { get; set; } = null!;

    [ForeignKey("IdProducto")]
    [InverseProperty("IngresoProductos")]
    public virtual Producto IdProductoNavigation { get; set; } = null!;

    [ForeignKey("IdUnidad")]
    [InverseProperty("IngresoProductos")]
    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
