using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Table("Usuario")]
public partial class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    [Column("Usuario")]
    [StringLength(30)]
    public string Usuario1 { get; set; } = null!;

    [StringLength(100)]
    public string Password { get; set; } = null!;

    [StringLength(50)]
    public string Email { get; set; } = null!;

    public int IdPersona { get; set; }

    [Column("IRol")]
    public int Irol { get; set; }

    public bool Estado { get; set; }

    [StringLength(100)]
    public string? Fotografia { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Error> Errors { get; set; } = new List<Error>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Historial> Historials { get; set; } = new List<Historial>();

    [ForeignKey("IdPersona")]
    [InverseProperty("Usuarios")]
    public virtual Persona IdPersonaNavigation { get; set; } = null!;

    [ForeignKey("Irol")]
    [InverseProperty("Usuarios")]
    public virtual Rol IrolNavigation { get; set; } = null!;
}
