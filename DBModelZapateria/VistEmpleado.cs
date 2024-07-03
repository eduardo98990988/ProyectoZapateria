using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Keyless]
public partial class VistEmpleado
{
    [Column("IRol")]
    public int Irol { get; set; }

    [StringLength(25)]
    public string NombreRol { get; set; } = null!;

    public int IdEmpleado { get; set; }

    [StringLength(30)]
    public string? ApellidoEmp { get; set; }

    [StringLength(15)]
    public string TipoDocumento { get; set; } = null!;

    [StringLength(20)]
    public string NumeroDocumento { get; set; } = null!;

    [StringLength(15)]
    public string Telefono { get; set; } = null!;

    [StringLength(50)]
    public string NombrePersona { get; set; } = null!;

    [StringLength(30)]
    public string Usuario { get; set; } = null!;

    [StringLength(50)]
    public string Email { get; set; } = null!;

    public int IdUsuario { get; set; }

    [Column(TypeName = "money")]
    public decimal Salario { get; set; }
}
