using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Table("Rol")]
public partial class Rol
{
    [Key]
    [Column("IRol")]
    public int Irol { get; set; }

    [StringLength(25)]
    public string NombreRol { get; set; } = null!;

    public string? DescripRol { get; set; }

    [InverseProperty("IrolNavigation")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
