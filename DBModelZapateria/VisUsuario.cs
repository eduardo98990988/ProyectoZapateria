using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Keyless]
public partial class VisUsuario
{
    public int IdUsuario { get; set; }
    [StringLength(30)]
    public string Usuario { get; set; } = null!;

    [StringLength(100)]
    public string Password { get; set; } = null!;

    [StringLength(50)]
    public string Email { get; set; } = null!;

    [StringLength(25)]
    public string NombreRol { get; set; } = null!;

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [StringLength(30)]
    public string TipoPersona { get; set; } = null!;

    [StringLength(50)]
    public string? Direccion { get; set; }
}
