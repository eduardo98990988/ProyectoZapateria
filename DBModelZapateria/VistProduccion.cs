using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Keyless]
public partial class VistProduccion
{
    public int CantidadProduccion { get; set; }

    [StringLength(50)]
    public string? Descripcion { get; set; }

    public int Meta { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaInicio { get; set; }

    [StringLength(20)]
    public string EstadoProduccion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaFin { get; set; }

    [StringLength(40)]
    public string? NombreProd { get; set; }

    [StringLength(20)]
    public string? CodigoProd { get; set; }
}
