using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Keyless]
public partial class VistCliente
{
    public int IdCliente { get; set; }

    [Column("IRol")]
    public int Irol { get; set; }

    public int IdUsuario { get; set; }

    public int IdPersona { get; set; }

    [StringLength(25)]
    public string NombreRol { get; set; } = null!;

    [StringLength(30)]
    public string Usuario { get; set; } = null!;

    [StringLength(50)]
    public string Email { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? NombreCliente { get; set; }

    [StringLength(15)]
    public string Telefono { get; set; } = null!;
}
