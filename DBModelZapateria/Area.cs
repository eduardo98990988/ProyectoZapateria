using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

[Table("Area")]
public partial class Area
{
    [Key]
    public int IdArea { get; set; }

    [StringLength(20)]
    public string? NombreArea { get; set; }

    [StringLength(50)]
    public string? DescripArea { get; set; }

    [InverseProperty("IdAreaNavigation")]
    public virtual ICollection<DetalleProduccion> DetalleProduccions { get; set; } = new List<DetalleProduccion>();
}
