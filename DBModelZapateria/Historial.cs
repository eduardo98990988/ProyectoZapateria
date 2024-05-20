using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Table("Historial")]
public partial class Historial
{
    [Key]
    public int IdHistorial { get; set; }

    public string? Detalle { get; set; }

    public string? TableName { get; set; }

    public int IdUsuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("Historials")]
    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
