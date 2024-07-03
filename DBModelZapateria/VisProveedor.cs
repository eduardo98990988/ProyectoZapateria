using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Keyless]
public partial class VisProveedor
{
    [StringLength(100)]
    [Unicode(false)]
    public string? NombreProveedor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaEntrega { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaPedido { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "money")]
    public decimal PrecioUnitario { get; set; }

    [StringLength(50)]
    public string NombreMaterial { get; set; } = null!;

    [StringLength(15)]
    public string Telefono { get; set; } = null!;

    [Column(TypeName = "money")]
    public decimal? MontoTotal { get; set; }

    public int IdProvedor { get; set; }

    public int IdComprobante { get; set; }

    public int IdMaterial { get; set; }
}
