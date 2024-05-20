using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[PrimaryKey("IdComprobante", "IdMaterial")]
[Table("ComprobanteDetalle")]
public partial class ComprobanteDetalle
{
    public int Cantidad { get; set; }

    [Key]
    public int IdComprobante { get; set; }

    [Key]
    public int IdMaterial { get; set; }

    [Column(TypeName = "money")]
    public decimal PrecioUnitario { get; set; }

    public int IdUnidad { get; set; }

    [ForeignKey("IdComprobante")]
    [InverseProperty("ComprobanteDetalles")]
    public virtual ComprobanteProvedor IdComprobanteNavigation { get; set; } = null!;

    [ForeignKey("IdMaterial")]
    [InverseProperty("ComprobanteDetalles")]
    public virtual Material IdMaterialNavigation { get; set; } = null!;

    [ForeignKey("IdUnidad")]
    [InverseProperty("ComprobanteDetalles")]
    public virtual Unidad IdUnidadNavigation { get; set; } = null!;
}
