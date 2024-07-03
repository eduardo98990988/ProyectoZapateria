using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Keyless]
public partial class VistSalidaMaterial
{
    public int Cantidad { get; set; }

    public int IdMaterial { get; set; }

    public int IdProduccion { get; set; }

    [StringLength(50)]
    public string NombreMaterial { get; set; } = null!;

    [StringLength(50)]
    public string? Estado { get; set; }

    public int Stock { get; set; }
}
