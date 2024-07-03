using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Keyless]
public partial class VistIngresoProducto
{
    public int Cantidad { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaIngreso { get; set; }

    public int Meta { get; set; }

    public int? CantidadFaltante { get; set; }

    [StringLength(40)]
    public string? NombreProd { get; set; }

    public int Stock { get; set; }

    [StringLength(20)]
    public string EstadoProduccion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaFin { get; set; }
}
