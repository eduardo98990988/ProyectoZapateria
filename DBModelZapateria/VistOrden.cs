using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Keyless]
public partial class VistOrden
{
    public int IdCliente { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaOrden { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaRequerido { get; set; }

    [StringLength(20)]
    public string EstadoOrden { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? NombreCliente { get; set; }

    [Column(TypeName = "money")]
    public decimal? PrecioUnitario { get; set; }

    [StringLength(40)]
    public string? NombreProd { get; set; }

    public double? MontoTotal { get; set; }

    public int Cantidad { get; set; }

    [StringLength(20)]
    public string? Categoria { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? CodigoOrden { get; set; }
}
