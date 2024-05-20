using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBModelZapateria;

public partial class _dbZapateriaModelContext : DbContext
{
    public _dbZapateriaModelContext()
    {
    }

    public _dbZapateriaModelContext(DbContextOptions<_dbZapateriaModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ComprobanteDetalle> ComprobanteDetalles { get; set; }

    public virtual DbSet<ComprobanteProvedor> ComprobanteProvedors { get; set; }

    public virtual DbSet<Credito> Creditos { get; set; }

    public virtual DbSet<DetalleCredio> DetalleCredios { get; set; }

    public virtual DbSet<DetalleEnvio> DetalleEnvios { get; set; }

    public virtual DbSet<DetalleOrden> DetalleOrdens { get; set; }

    public virtual DbSet<DetalleProduccion> DetalleProduccions { get; set; }

    public virtual DbSet<DetalleProducto> DetalleProductos { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<Historial> Historials { get; set; }

    public virtual DbSet<IngresoProducto> IngresoProductos { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<Orden> Ordens { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Produccion> Produccions { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Provedor> Provedors { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<SalidaMaterial> SalidaMaterials { get; set; }

    public virtual DbSet<Trasporte> Trasportes { get; set; }

    public virtual DbSet<Unidad> Unidads { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VisUsuario> VisUsuarios { get; set; }

    public virtual DbSet<VistProduccion> VistProduccions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-IFHIDDS\\SQLEXPRESS;Initial Catalog=DLopez;Integrated Security=True;Trusted_Connection=true;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.IdArea).HasName("XPKArea");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("XPKCliente");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Clientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_117");
        });

        modelBuilder.Entity<ComprobanteDetalle>(entity =>
        {
            entity.HasKey(e => new { e.IdComprobante, e.IdMaterial }).HasName("XPKComprobanteDetalle");

            entity.HasOne(d => d.IdComprobanteNavigation).WithMany(p => p.ComprobanteDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_99");

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.ComprobanteDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_100");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.ComprobanteDetalles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_146");
        });

        modelBuilder.Entity<ComprobanteProvedor>(entity =>
        {
            entity.HasKey(e => e.IdComprobante).HasName("XPKComprobanteProvedor");

            entity.HasOne(d => d.IdProvedorNavigation).WithMany(p => p.ComprobanteProvedors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_98");
        });

        modelBuilder.Entity<Credito>(entity =>
        {
            entity.HasKey(e => e.IdCredito).HasName("XPKCredito");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Creditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_123");
        });

        modelBuilder.Entity<DetalleCredio>(entity =>
        {
            entity.HasKey(e => new { e.IdDetalleCredito, e.IdOrden, e.IdCredito }).HasName("XPKDetalleCredio");

            entity.Property(e => e.IdDetalleCredito).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdCreditoNavigation).WithMany(p => p.DetalleCredios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_122");

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleCredios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_72");
        });

        modelBuilder.Entity<DetalleEnvio>(entity =>
        {
            entity.HasKey(e => new { e.IdDetalleEnvio, e.IdTransporte, e.IdOrden }).HasName("XPKDetalleEnvio");

            entity.Property(e => e.IdDetalleEnvio).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleEnvios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_139");

            entity.HasOne(d => d.IdTransporteNavigation).WithMany(p => p.DetalleEnvios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_138");
        });

        modelBuilder.Entity<DetalleOrden>(entity =>
        {
            entity.HasKey(e => new { e.IdDetalleOrden, e.IdOrden, e.IdProducto, e.Talla }).HasName("XPKDetalleOrden");

            entity.Property(e => e.IdDetalleOrden).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleOrdens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_116");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleOrdens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_144");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.DetalleOrdens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_151");
        });

        modelBuilder.Entity<DetalleProduccion>(entity =>
        {
            entity.HasKey(e => new { e.IdDetalleProduccion, e.IdProduccion, e.IdOrden, e.IdArea, e.IdEmpleado }).HasName("XPKDetalleProduccion");

            entity.Property(e => e.IdDetalleProduccion).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdAreaNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_108");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_114");

            entity.HasOne(d => d.IdOrdenNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_143");

            entity.HasOne(d => d.IdProduccionNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_107");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.DetalleProduccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_148");
        });

        modelBuilder.Entity<DetalleProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdDetalleProducto, e.IdModelo, e.IdProducto, e.Talla }).HasName("XPKDetalleProducto");

            entity.Property(e => e.IdDetalleProducto).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion).IsFixedLength();
            entity.Property(e => e.Material).IsFixedLength();

            entity.HasOne(d => d.IdModeloNavigation).WithMany(p => p.DetalleProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_125");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_126");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("XPKEmpleado");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Empleados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_112");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.IdError).HasName("XPKError");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Errors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_136");
        });

        modelBuilder.Entity<Historial>(entity =>
        {
            entity.HasKey(e => e.IdHistorial).HasName("XPKHistorial");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Historials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_135");
        });

        modelBuilder.Entity<IngresoProducto>(entity =>
        {
            entity.HasKey(e => new { e.IdIngresoProducto, e.IdProduccion, e.IdProducto }).HasName("XPKIngresoProducto");

            entity.Property(e => e.IdIngresoProducto).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdProduccionNavigation).WithMany(p => p.IngresoProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_110");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.IngresoProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_111");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.IngresoProductos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_149");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasKey(e => e.IdMaterial).HasName("XPKMaterial");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.Materials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_152");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasKey(e => e.IdModelo).HasName("XPKModelo");
        });

        modelBuilder.Entity<Orden>(entity =>
        {
            entity.HasKey(e => e.IdOrden).HasName("XPKOrden");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Ordens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_74");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Ordens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_153");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("XPKPersona");
        });

        modelBuilder.Entity<Produccion>(entity =>
        {
            entity.HasKey(e => e.IdProduccion).HasName("XPKProduccion");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.Produccions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_145");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("XPKProducto");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_150");
        });

        modelBuilder.Entity<Provedor>(entity =>
        {
            entity.HasKey(e => e.IdProvedor).HasName("XPKProvedor");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Provedors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_97");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Irol).HasName("XPKRol");
        });

        modelBuilder.Entity<SalidaMaterial>(entity =>
        {
            entity.HasKey(e => new { e.IdSalidaMaterial, e.IdMaterial, e.IdProduccion }).HasName("XPKSalidaMaterial");

            entity.Property(e => e.IdSalidaMaterial).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdMaterialNavigation).WithMany(p => p.SalidaMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_104");

            entity.HasOne(d => d.IdProduccionNavigation).WithMany(p => p.SalidaMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_103");

            entity.HasOne(d => d.IdUnidadNavigation).WithMany(p => p.SalidaMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_147");
        });

        modelBuilder.Entity<Trasporte>(entity =>
        {
            entity.HasKey(e => e.IdTransporte).HasName("XPKTrasporte");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Trasportes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_118");
        });

        modelBuilder.Entity<Unidad>(entity =>
        {
            entity.HasKey(e => e.IdUnidad).HasName("XPKUnidad");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("XPKUsuario");

            entity.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_121");

            entity.HasOne(d => d.IrolNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("R_124");
        });

        modelBuilder.Entity<VisUsuario>(entity =>
        {
            entity.ToView("VisUsuario");
        });

        modelBuilder.Entity<VistProduccion>(entity =>
        {
            entity.ToView("VistProduccion");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
