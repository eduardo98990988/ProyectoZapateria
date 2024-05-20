using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[PrimaryKey("IdDetalleEnvio", "IdTransporte", "IdOrden")]
[Table("DetalleEnvio")]
public partial class DetalleEnvio
{
    [Key]
    public int IdTransporte { get; set; }

    [Key]
    public int IdOrden { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaEnvio { get; set; }

    [StringLength(10)]
    public string? CodigoUbigeo { get; set; }

    [StringLength(50)]
    public string? Direccion { get; set; }

    [Key]
    [Column("idDetalleEnvio")]
    public int IdDetalleEnvio { get; set; }

    [ForeignKey("IdOrden")]
    [InverseProperty("DetalleEnvios")]
    public virtual Orden IdOrdenNavigation { get; set; } = null!;

    [ForeignKey("IdTransporte")]
    [InverseProperty("DetalleEnvios")]
    public virtual Trasporte IdTransporteNavigation { get; set; } = null!;
}
