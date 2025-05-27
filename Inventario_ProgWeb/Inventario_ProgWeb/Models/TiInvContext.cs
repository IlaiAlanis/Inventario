using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Inventario_ProgWeb.Models;

public partial class TiInvContext : DbContext
{
    public TiInvContext()
    {
    }

    public TiInvContext(DbContextOptions<TiInvContext> options)
        : base(options)
    {
    }

    public virtual DbSet<InvAsignacionHistorial> InvAsignacionHistorials { get; set; }

    public virtual DbSet<InvAutidoriaDispositivo> InvAutidoriaDispositivos { get; set; }

    public virtual DbSet<InvCatalogoAlmacenamiento> InvCatalogoAlmacenamientoes { get; set; }

    public virtual DbSet<InvCatalogoLicencia> InvCatalogoLicencias { get; set; }

    public virtual DbSet<InvCatalogoMarca> InvCatalogoMarcas { get; set; }

    public virtual DbSet<InvCatalogoO> InvCatalogoOs { get; set; }

    public virtual DbSet<InvCatalogoProcesador> InvCatalogoProcesadors { get; set; }

    public virtual DbSet<InvCatalogoProveedor> InvCatalogoProveedors { get; set; }

    public virtual DbSet<InvCatalogoRam> InvCatalogoRams { get; set; }

    public virtual DbSet<InvCatalogoUbicacion> InvCatalogoUbicacions { get; set; }

    public virtual DbSet<InvDispositivo> InvDispositivoes { get; set; }

    public virtual DbSet<InvDispositivoAsignacion> InvDispositivoAsignacions { get; set; }

    public virtual DbSet<InvDispositivoControl> InvDispositivoControls { get; set; }

    public virtual DbSet<InvDispositivoFinanciero> InvDispositivoFinancieroes { get; set; }

    public virtual DbSet<InvDispositivoHistorial> InvDispositivoHistorials { get; set; }

    public virtual DbSet<InvDispositivoTecnico> InvDispositivoTecnicoes { get; set; }

    public virtual DbSet<InvEstatusDispositivo> InvEstatusDispositivoes { get; set; }

    public virtual DbSet<InvEstatusReporte> InvEstatusReportes { get; set; }

    public virtual DbSet<InvEstatusResponsiva> InvEstatusResponsivas { get; set; }

    public virtual DbSet<InvFactura> InvFacturas { get; set; }

    public virtual DbSet<InvIncidencia> InvIncidencias { get; set; }

    public virtual DbSet<InvIncidenciaHistorial> InvIncidenciaHistorials { get; set; }

    public virtual DbSet<InvInventarioBase> InvInventarioBases { get; set; }

    public virtual DbSet<InvInventarioParcial> InvInventarioParcials { get; set; }

    public virtual DbSet<InvLicenciaAsignacion> InvLicenciaAsignacions { get; set; }

    public virtual DbSet<InvLicenciaRenovacion> InvLicenciaRenovacions { get; set; }

    public virtual DbSet<InvModeloDispositivo> InvModeloDispositivoes { get; set; }

    public virtual DbSet<InvRemplazo> InvRemplazoes { get; set; }

    public virtual DbSet<InvResponsiva> InvResponsivas { get; set; }

    public virtual DbSet<InvTipoAdquisicion> InvTipoAdquisicions { get; set; }

    public virtual DbSet<InvTipoAlmacenamiento> InvTipoAlmacenamientoes { get; set; }

    public virtual DbSet<InvTipoDispositivo> InvTipoDispositivoes { get; set; }

    public virtual DbSet<InvTipoHallazgo> InvTipoHallazgoes { get; set; }

    public virtual DbSet<InvTipoIncidencia> InvTipoIncidencias { get; set; }

    public virtual DbSet<InvTipoReporte> InvTipoReportes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=TI_INV");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InvAsignacionHistorial>(entity =>
        {
            entity.HasKey(e => e.IdAsignacionHistorial).HasName("PK__INV_asig__1186E62C31C54548");

            entity.ToTable("INV_asignacion_historial");

            entity.Property(e => e.IdAsignacionHistorial).HasColumnName("id_asignacion_historial");
            entity.Property(e => e.DepartamentoId).HasColumnName("departamento_id");
            entity.Property(e => e.DispositivoId).HasColumnName("dispositivo_id");
            entity.Property(e => e.FechaAsignacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_asignacion");
            entity.Property(e => e.FechaDesasignacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_desasignacion");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Dispositivo).WithMany(p => p.InvAsignacionHistorials)
                .HasForeignKey(d => d.DispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_asignacion_historial_dispositivo_id");
        });

        modelBuilder.Entity<InvAutidoriaDispositivo>(entity =>
        {
            entity.HasKey(e => e.IdAuditoriaDispositivo).HasName("PK__INV_auti__9D35C9BC7D26F150");

            entity.ToTable("INV_autidoria_dispositivos");

            entity.Property(e => e.IdAuditoriaDispositivo).HasColumnName("id_auditoria_dispositivo");
            entity.Property(e => e.AlmacenamientoId).HasColumnName("almacenamiento_id");
            entity.Property(e => e.AudititoriaAceptado).HasColumnName("audititoria_aceptado");
            entity.Property(e => e.AuditoriaComentario)
                .HasMaxLength(200)
                .HasColumnName("auditoria_comentario");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("costo");
            entity.Property(e => e.DepartamentoId).HasColumnName("departamento_id");
            entity.Property(e => e.DispositivoId).HasColumnName("dispositivo_id");
            entity.Property(e => e.FechaAdquisicion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_adquisicion");
            entity.Property(e => e.FechaFinGarantia)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin_garantia");
            entity.Property(e => e.FechaInicioGarantia)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio_garantia");
            entity.Property(e => e.HallazgoId).HasColumnName("hallazgo_id");
            entity.Property(e => e.Hostname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hostname");
            entity.Property(e => e.IdentificadorDispositivo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("identificador_dispositivo");
            entity.Property(e => e.InventarioParcialId).HasColumnName("inventario_parcial_id");
            entity.Property(e => e.Mac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mac");
            entity.Property(e => e.MarcaId).HasColumnName("marca_id");
            entity.Property(e => e.ModeloDispositivoId).HasColumnName("modelo_dispositivo_id");
            entity.Property(e => e.OsId).HasColumnName("os_id");
            entity.Property(e => e.ProcesadorId).HasColumnName("procesador_id");
            entity.Property(e => e.RamId).HasColumnName("ram_id");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.UbicacionId).HasColumnName("ubicacion_id");
            entity.Property(e => e.UsuarioAsignadoId).HasColumnName("usuario_asignado_id");

            entity.HasOne(d => d.Dispositivo).WithMany(p => p.InvAutidoriaDispositivoes)
                .HasForeignKey(d => d.DispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_autidoria_dispositivos_dispositivo_id");

            entity.HasOne(d => d.Hallazgo).WithMany(p => p.InvAutidoriaDispositivoes)
                .HasForeignKey(d => d.HallazgoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_autidoria_dispositivos_hallazgo_id");

            entity.HasOne(d => d.InventarioParcial).WithMany(p => p.InvAutidoriaDispositivoes)
                .HasForeignKey(d => d.InventarioParcialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_autidoria_dispositivos_inventario_parcial_id");
        });

        modelBuilder.Entity<InvCatalogoAlmacenamiento>(entity =>
        {
            entity.HasKey(e => e.IdAlmacenamiento).HasName("PK__INV_cata__E5651AF15727F768");

            entity.ToTable("INV_catalogo_almacenamiento");

            entity.Property(e => e.IdAlmacenamiento).HasColumnName("id_almacenamiento");
            entity.Property(e => e.Capacidad)
                .HasMaxLength(50)
                .HasColumnName("capacidad");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.TipoAlmacenamiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_almacenamiento");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvCatalogoLicencia>(entity =>
        {
            entity.HasKey(e => e.IdCatalogoLicencia).HasName("PK__INV_cata__AE66460C7D9EB224");

            entity.ToTable("INV_catalogo_licencia");

            entity.Property(e => e.IdCatalogoLicencia).HasColumnName("id_catalogo_licencia");
            entity.Property(e => e.CantidadTotal).HasColumnName("cantidad_total");
            entity.Property(e => e.ClaveLicencia)
                .HasMaxLength(100)
                .HasColumnName("clave_licencia");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .HasColumnName("comentario");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");
            entity.Property(e => e.Tipo)
                .HasMaxLength(50)
                .HasColumnName("tipo");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .HasColumnName("version");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.InvCatalogoLicencias)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_catalogo_licencia_proveedor_id");
        });

        modelBuilder.Entity<InvCatalogoMarca>(entity =>
        {
            entity.HasKey(e => e.IdMarca).HasName("PK__INV_cata__7E43E99E9C673F70");

            entity.ToTable("INV_catalogo_marca");

            entity.Property(e => e.IdMarca).HasColumnName("id_marca");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvCatalogoO>(entity =>
        {
            entity.HasKey(e => e.IdOs).HasName("PK__INV_cata__0148BB6911369E87");

            entity.ToTable("INV_catalogo_os");

            entity.Property(e => e.IdOs).HasColumnName("id_os");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvCatalogoProcesador>(entity =>
        {
            entity.HasKey(e => e.IdProcesador).HasName("PK__INV_cata__44A1CD024ECCBC03");

            entity.ToTable("INV_catalogo_procesador");

            entity.Property(e => e.IdProcesador).HasColumnName("id_procesador");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.MarcaId).HasColumnName("marca_id");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");

            entity.HasOne(d => d.Marca).WithMany(p => p.InvCatalogoProcesadors)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_catalogo_procesador_marca_id");
        });

        modelBuilder.Entity<InvCatalogoProveedor>(entity =>
        {
            entity.HasKey(e => e.IdCatalogoProveedor).HasName("PK__INV_cata__332C5D2D962C4101");

            entity.ToTable("INV_catalogo_proveedor");

            entity.Property(e => e.IdCatalogoProveedor).HasColumnName("id_catalogo_proveedor");
            entity.Property(e => e.Comentario)
                .HasMaxLength(300)
                .HasColumnName("comentario");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .HasColumnName("correo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(300)
                .HasColumnName("direccion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .HasColumnName("rfc");
            entity.Property(e => e.SitioWeb)
                .HasMaxLength(200)
                .HasColumnName("sitio_web");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("telefono");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvCatalogoRam>(entity =>
        {
            entity.HasKey(e => e.IdRam).HasName("PK__INV_cata__6ABE0F817C098C90");

            entity.ToTable("INV_catalogo_ram");

            entity.Property(e => e.IdRam).HasColumnName("id_ram");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvCatalogoUbicacion>(entity =>
        {
            entity.HasKey(e => e.IdUbicacion).HasName("PK__INV_cata__81BAA591F41C0AC5");

            entity.ToTable("INV_catalogo_ubicacion");

            entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvDispositivo>(entity =>
        {
            entity.HasKey(e => e.IdDispositivo).HasName("PK__INV_disp__FD7B94E517175837");

            entity.ToTable("INV_dispositivo");

            entity.HasIndex(e => e.MarcaId, "IX_INV_dispositivo_marca_id");

            entity.HasIndex(e => e.ModeloDispositivoId, "IX_INV_dispositivo_modelo_dispositivo_id");

            entity.HasIndex(e => e.TipoDispositivoId, "IX_INV_dispositivo_tipo_dispositivo_id");

            entity.HasIndex(e => new { e.TipoDispositivoId, e.IdSecuencia }, "UQ_INV_dispositivo_tipo_dispositivo_id_id_secuencia").IsUnique();

            entity.HasIndex(e => e.IdSecuencia, "UQ__INV_disp__4C64D44973369483").IsUnique();

            entity.Property(e => e.IdDispositivo).HasColumnName("id_dispositivo");
            entity.Property(e => e.Hostname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hostname");
            entity.Property(e => e.IdSecuencia).HasColumnName("id_secuencia");
            entity.Property(e => e.IdentificadorDispositivo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("identificador_dispositivo");
            entity.Property(e => e.MarcaId).HasColumnName("marca_id");
            entity.Property(e => e.ModeloDispositivoId).HasColumnName("modelo_dispositivo_id");
            entity.Property(e => e.Serie)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.TipoDispositivoId).HasColumnName("tipo_dispositivo_id");

            entity.HasOne(d => d.Marca).WithMany(p => p.InvDispositivoes)
                .HasForeignKey(d => d.MarcaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_marca_id");

            entity.HasOne(d => d.ModeloDispositivo).WithMany(p => p.InvDispositivoes)
                .HasForeignKey(d => d.ModeloDispositivoId)
                .HasConstraintName("FK_INV_dispositivo_modelo_dispositivo_id");

            entity.HasOne(d => d.TipoDispositivo).WithMany(p => p.InvDispositivoes)
                .HasForeignKey(d => d.TipoDispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_tipo_dispositivo_id");
        });

        modelBuilder.Entity<InvDispositivoAsignacion>(entity =>
        {
            entity.HasKey(e => e.DispositivoId).HasName("PK__INV_disp__3942256425B27398");

            entity.ToTable("INV_dispositivo_asignacion");

            entity.HasIndex(e => e.DepartamentoId, "IX_INV_dispositivo_asignacion_departamento_id");

            entity.HasIndex(e => e.EstatusDispositivoId, "IX_INV_dispositivo_asignacion_estatus_dispositivo_id");

            entity.HasIndex(e => e.UbicacionId, "IX_INV_dispositivo_asignacion_ubicacion_id");

            entity.HasIndex(e => e.UsuarioAsignadoId, "IX_INV_dispositivo_asignacion_usuario_asignado_id");

            entity.Property(e => e.DispositivoId)
                .ValueGeneratedNever()
                .HasColumnName("dispositivo_id");
            entity.Property(e => e.DepartamentoId).HasColumnName("departamento_id");
            entity.Property(e => e.EstatusDispositivoId).HasColumnName("estatus_dispositivo_id");
            entity.Property(e => e.ResponsivaId).HasColumnName("responsiva_id");
            entity.Property(e => e.UbicacionId).HasColumnName("ubicacion_id");
            entity.Property(e => e.UsuarioAsignadoId).HasColumnName("usuario_asignado_id");

            entity.HasOne(d => d.Dispositivo).WithOne(p => p.InvDispositivoAsignacion)
                .HasForeignKey<InvDispositivoAsignacion>(d => d.DispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_asignacion_dispositivo_id");

            entity.HasOne(d => d.EstatusDispositivo).WithMany(p => p.InvDispositivoAsignacions)
                .HasForeignKey(d => d.EstatusDispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_asignacion_estatus_dispositivo_id");

            entity.HasOne(d => d.Ubicacion).WithMany(p => p.InvDispositivoAsignacions)
                .HasForeignKey(d => d.UbicacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_asignacion_ubicacion_id");
        });

        modelBuilder.Entity<InvDispositivoControl>(entity =>
        {
            entity.HasKey(e => e.DispositivoId).HasName("PK__INV_disp__394225645F35D670");

            entity.ToTable("INV_dispositivo_control");

            entity.Property(e => e.DispositivoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("dispositivo_id");
            entity.Property(e => e.Comentario)
                .HasMaxLength(200)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");

            entity.HasOne(d => d.Dispositivo).WithOne(p => p.InvDispositivoControl)
                .HasForeignKey<InvDispositivoControl>(d => d.DispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_control_dispositivo_id");
        });

        modelBuilder.Entity<InvDispositivoFinanciero>(entity =>
        {
            entity.HasKey(e => e.DispositivoId).HasName("PK__INV_disp__39422564AB9328A3");

            entity.ToTable("INV_dispositivo_financiero");

            entity.HasIndex(e => e.DispositivoId, "IX_INV_dispositivo_financiero_dispositivo_id");

            entity.HasIndex(e => e.FacturaId, "IX_INV_dispositivo_financiero_factura_id");

            entity.HasIndex(e => e.RemplazoId, "IX_INV_dispositivo_financiero_remplazo_id");

            entity.Property(e => e.DispositivoId)
                .ValueGeneratedNever()
                .HasColumnName("dispositivo_id");
            entity.Property(e => e.Contrato)
                .HasMaxLength(100)
                .HasColumnName("contrato");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("costo");
            entity.Property(e => e.FacturaId).HasColumnName("factura_id");
            entity.Property(e => e.FechaAdquisicion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_adquisicion");
            entity.Property(e => e.FechaFinGarantia)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin_garantia");
            entity.Property(e => e.FechaInicioGarantia)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio_garantia");
            entity.Property(e => e.RemplazoId).HasColumnName("remplazo_id");

            entity.HasOne(d => d.Dispositivo).WithOne(p => p.InvDispositivoFinanciero)
                .HasForeignKey<InvDispositivoFinanciero>(d => d.DispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_financiero_dispositivo_id");

            entity.HasOne(d => d.Factura).WithMany(p => p.InvDispositivoFinancieroes)
                .HasForeignKey(d => d.FacturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_financiero_factura_id");

            entity.HasOne(d => d.Remplazo).WithMany(p => p.InvDispositivoFinancieroes)
                .HasForeignKey(d => d.RemplazoId)
                .HasConstraintName("FK_INV_dispositivo_financiero_remplazo_id");
        });

        modelBuilder.Entity<InvDispositivoHistorial>(entity =>
        {
            entity.HasKey(e => e.IdDispositivoHistorial).HasName("PK__INV_disp__63D7A5266117E427");

            entity.ToTable("INV_dispositivo_historial");

            entity.Property(e => e.IdDispositivoHistorial).HasColumnName("id_dispositivo_historial");
            entity.Property(e => e.CampoModificado)
                .HasMaxLength(50)
                .HasColumnName("campo_modificado");
            entity.Property(e => e.Comentario)
                .HasMaxLength(300)
                .HasColumnName("comentario");
            entity.Property(e => e.DispositivoId).HasColumnName("dispositivo_id");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.UsuarioResponsableId).HasColumnName("usuario_responsable_id");
            entity.Property(e => e.ValorAnterior)
                .HasMaxLength(250)
                .HasColumnName("valor_anterior");
            entity.Property(e => e.ValorNuevo)
                .HasMaxLength(250)
                .HasColumnName("valor_nuevo");

            entity.HasOne(d => d.Dispositivo).WithMany(p => p.InvDispositivoHistorials)
                .HasForeignKey(d => d.DispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_historial_dispositivo_id");
        });

        modelBuilder.Entity<InvDispositivoTecnico>(entity =>
        {
            entity.HasKey(e => e.DispositivoId).HasName("PK__INV_disp__394225649B543350");

            entity.ToTable("INV_dispositivo_tecnico");

            entity.HasIndex(e => e.AlmacenamientoId, "IX_INV_dispositivo_tecnico_almacenamiento_id");

            entity.HasIndex(e => e.DispositivoId, "IX_INV_dispositivo_tecnico_dispositivo_id");

            entity.HasIndex(e => e.OsId, "IX_INV_dispositivo_tecnico_os_id");

            entity.HasIndex(e => e.ProcesadorId, "IX_INV_dispositivo_tecnico_procesador_id");

            entity.HasIndex(e => e.RamId, "IX_INV_dispositivo_tecnico_ram_id");

            entity.Property(e => e.DispositivoId)
                .ValueGeneratedNever()
                .HasColumnName("dispositivo_id");
            entity.Property(e => e.AlmacenamientoId).HasColumnName("almacenamiento_id");
            entity.Property(e => e.Mac)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mac");
            entity.Property(e => e.OsId).HasColumnName("os_id");
            entity.Property(e => e.ProcesadorId).HasColumnName("procesador_id");
            entity.Property(e => e.RamId).HasColumnName("ram_id");

            entity.HasOne(d => d.Almacenamiento).WithMany(p => p.InvDispositivoTecnicoes)
                .HasForeignKey(d => d.AlmacenamientoId)
                .HasConstraintName("FK_INV_dispositivo_tecnico_almacenamiento_id");

            entity.HasOne(d => d.Dispositivo).WithOne(p => p.InvDispositivoTecnico)
                .HasForeignKey<InvDispositivoTecnico>(d => d.DispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_tecnico_dispositivo_id");

            entity.HasOne(d => d.Os).WithMany(p => p.InvDispositivoTecnicoes)
                .HasForeignKey(d => d.OsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_tecnico_os_id");

            entity.HasOne(d => d.Procesador).WithMany(p => p.InvDispositivoTecnicoes)
                .HasForeignKey(d => d.ProcesadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_dispositivo_tecnico_procesador_id");

            entity.HasOne(d => d.Ram).WithMany(p => p.InvDispositivoTecnicoes)
                .HasForeignKey(d => d.RamId)
                .HasConstraintName("FK_INV_dispositivo_tecnico_ram_id");
        });

        modelBuilder.Entity<InvEstatusDispositivo>(entity =>
        {
            entity.HasKey(e => e.IdEstatusDispositivo).HasName("PK__INV_esta__4176546C7E938200");

            entity.ToTable("INV_estatus_dispositivo");

            entity.Property(e => e.IdEstatusDispositivo).HasColumnName("id_estatus_dispositivo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvEstatusReporte>(entity =>
        {
            entity.HasKey(e => e.IdEstatusReporte).HasName("PK__INV_esta__62F15B018EF3B65A");

            entity.ToTable("INV_estatus_reporte");

            entity.Property(e => e.IdEstatusReporte).HasColumnName("id_estatus_reporte");
            entity.Property(e => e.ComentarioAuditoria)
                .HasMaxLength(200)
                .HasColumnName("comentario_auditoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvEstatusResponsiva>(entity =>
        {
            entity.HasKey(e => e.IdEstatusResponsiva).HasName("PK__INV_esta__E62E2D0E26EC9ED4");

            entity.ToTable("INV_estatus_responsiva");

            entity.Property(e => e.IdEstatusResponsiva).HasColumnName("id_estatus_responsiva");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvFactura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__INV_fact__6C08ED53844D2F58");

            entity.ToTable("INV_factura");

            entity.HasIndex(e => e.AdquisicionId, "IX_INV_factura_adquisicion_id");

            entity.HasIndex(e => e.ProveedorId, "IX_INV_factura_proveedor_id");

            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.AdquisicionId).HasColumnName("adquisicion_id");
            entity.Property(e => e.CantidadDispositivo).HasColumnName("cantidad_dispositivo");
            entity.Property(e => e.CantidadDispositivoAsignado).HasColumnName("cantidad_dispositivo_asignado");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaTimbrado)
                .HasColumnType("datetime")
                .HasColumnName("fecha_timbrado");
            entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");
            entity.Property(e => e.RutaPdf)
                .HasMaxLength(500)
                .HasColumnName("ruta_pdf");
            entity.Property(e => e.RutaXml)
                .HasMaxLength(500)
                .HasColumnName("ruta_xml");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(11, 2)")
                .HasColumnName("total");
            entity.Property(e => e.Uuid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("uuid");

            entity.HasOne(d => d.Adquisicion).WithMany(p => p.InvFacturas)
                .HasForeignKey(d => d.AdquisicionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_factura_adquisicion_id");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.InvFacturas)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_factura_proveedor_id");
        });

        modelBuilder.Entity<InvIncidencia>(entity =>
        {
            entity.HasKey(e => e.IdIncidencia).HasName("PK__INV_inci__D7757E76457B4DD4");

            entity.ToTable("INV_incidencia");

            entity.HasIndex(e => e.DispositivoId, "IX_INV_incidencia_dispositivo_id");

            entity.HasIndex(e => e.EstatusReporteId, "IX_INV_incidencia_estatus_reporte_id");

            entity.HasIndex(e => e.TipoIncidenciaId, "IX_INV_incidencia_tipo_incidencia_id");

            entity.HasIndex(e => e.TipoReporteId, "IX_INV_incidencia_tipo_reporte_id");

            entity.HasIndex(e => e.UsuarioId, "IX_INV_incidencia_usuario_id");

            entity.Property(e => e.IdIncidencia).HasColumnName("id_incidencia");
            entity.Property(e => e.Comentario)
                .HasMaxLength(150)
                .HasColumnName("comentario");
            entity.Property(e => e.DepartamentoId).HasColumnName("departamento_id");
            entity.Property(e => e.DispositivoId).HasColumnName("dispositivo_id");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.EstatusReporteId).HasColumnName("estatus_reporte_id");
            entity.Property(e => e.FechaFin)
                .HasColumnType("datetime")
                .HasColumnName("fecha_fin");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.NumeroCaso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numero_caso");
            entity.Property(e => e.TipoIncidenciaId).HasColumnName("tipo_incidencia_id");
            entity.Property(e => e.TipoReporteId).HasColumnName("tipo_reporte_id");
            entity.Property(e => e.UbicacionId).HasColumnName("ubicacion_id");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Dispositivo).WithMany(p => p.InvIncidencias)
                .HasForeignKey(d => d.DispositivoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_incidencia_dispositivo_id");

            entity.HasOne(d => d.EstatusReporte).WithMany(p => p.InvIncidencias)
                .HasForeignKey(d => d.EstatusReporteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_incidencia_estatus_reporte_id");

            entity.HasOne(d => d.TipoIncidencia).WithMany(p => p.InvIncidencias)
                .HasForeignKey(d => d.TipoIncidenciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_incidencia_tipo_incidencia_id");

            entity.HasOne(d => d.TipoReporte).WithMany(p => p.InvIncidencias)
                .HasForeignKey(d => d.TipoReporteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_incidencia_tipo_reporte_id");

            entity.HasOne(d => d.Ubicacion).WithMany(p => p.InvIncidencias)
                .HasForeignKey(d => d.UbicacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_incidencia_ubicacion_id");
        });

        modelBuilder.Entity<InvIncidenciaHistorial>(entity =>
        {
            entity.HasKey(e => e.IdIncidenciaHistorial).HasName("PK__INV_inci__B359169EC80BED8D");

            entity.ToTable("INV_incidencia_historial");

            entity.Property(e => e.IdIncidenciaHistorial).HasColumnName("id_incidencia_historial");
            entity.Property(e => e.CampoModificado)
                .HasMaxLength(50)
                .HasColumnName("campo_modificado");
            entity.Property(e => e.Comentario)
                .HasMaxLength(300)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaEvento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_evento");
            entity.Property(e => e.IncidenciaId).HasColumnName("incidencia_id");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
            entity.Property(e => e.ValorAnterior)
                .HasMaxLength(250)
                .HasColumnName("valor_anterior");
            entity.Property(e => e.ValorNuevo)
                .HasMaxLength(250)
                .HasColumnName("valor_nuevo");

            entity.HasOne(d => d.Incidencia).WithMany(p => p.InvIncidenciaHistorials)
                .HasForeignKey(d => d.IncidenciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_incidencia_historial_incidencia_id");
        });

        modelBuilder.Entity<InvInventarioBase>(entity =>
        {
            entity.HasKey(e => e.IdInventarioBase).HasName("PK__INV_inve__7D6A2645792A8301");

            entity.ToTable("INV_inventario_base");

            entity.Property(e => e.IdInventarioBase).HasColumnName("id_inventario_base");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvInventarioParcial>(entity =>
        {
            entity.HasKey(e => e.IdInventarioParcial).HasName("PK__INV_inve__DEA37DED34618CD5");

            entity.ToTable("INV_inventario_parcial");

            entity.Property(e => e.IdInventarioParcial).HasColumnName("id_inventario_parcial");
            entity.Property(e => e.DepartamentoId).HasColumnName("departamento_id");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.InventarioBaseId).HasColumnName("inventario_base_id");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvLicenciaAsignacion>(entity =>
        {
            entity.HasKey(e => e.IdLicenciaAsignacion).HasName("PK__INV_lice__C9E03063A15E6738");

            entity.ToTable("INV_licencia_asignacion");

            entity.HasIndex(e => e.CatalogoLicenciaId, "IX_INV_licencia_asignacion_catalogo_licencia_id");

            entity.HasIndex(e => e.DispositivoId, "IX_INV_licencia_asignacion_dispositivo_id");

            entity.HasIndex(e => e.UsuarioAsignacionId, "IX_INV_licencia_asignacion_usuario_asignacion_id");

            entity.Property(e => e.IdLicenciaAsignacion).HasColumnName("id_licencia_asignacion");
            entity.Property(e => e.CatalogoLicenciaId).HasColumnName("catalogo_licencia_id");
            entity.Property(e => e.ClaveAsignada)
                .HasMaxLength(100)
                .HasColumnName("clave_asignada");
            entity.Property(e => e.DispositivoId).HasColumnName("dispositivo_id");
            entity.Property(e => e.FechaAsignacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_asignacion");
            entity.Property(e => e.FechaExpiracion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_expiracion");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
            entity.Property(e => e.UsuarioAsignacionId).HasColumnName("usuario_asignacion_id");

            entity.HasOne(d => d.CatalogoLicencia).WithMany(p => p.InvLicenciaAsignacions)
                .HasForeignKey(d => d.CatalogoLicenciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_licencia_asignacion_catalogo_licencia_id");

            entity.HasOne(d => d.Dispositivo).WithMany(p => p.InvLicenciaAsignacions)
                .HasForeignKey(d => d.DispositivoId)
                .HasConstraintName("FK_INV_licencia_asignacion_dispositivo_id");
        });

        modelBuilder.Entity<InvLicenciaRenovacion>(entity =>
        {
            entity.HasKey(e => e.IdLicenciaRenovacion).HasName("PK__INV_lice__E0C43418E0327E8E");

            entity.ToTable("INV_licencia_renovacion");

            entity.Property(e => e.IdLicenciaRenovacion).HasColumnName("id_licencia_renovacion");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaNuevoVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nuevo_vencimiento");
            entity.Property(e => e.FechaRenovacion)
                .HasColumnType("datetime")
                .HasColumnName("fecha_renovacion");
            entity.Property(e => e.LicenciaAsignacionId).HasColumnName("licencia_asignacion_id");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
            entity.Property(e => e.UsuarioAsignacionId).HasColumnName("usuario_asignacion_id");

            entity.HasOne(d => d.LicenciaAsignacion).WithMany(p => p.InvLicenciaRenovacions)
                .HasForeignKey(d => d.LicenciaAsignacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_licencia_renovacion_licencia_asignacion_id");
        });

        modelBuilder.Entity<InvModeloDispositivo>(entity =>
        {
            entity.HasKey(e => e.IdModeloDispositivo).HasName("PK__INV_mode__C7D5B52F909850AC");

            entity.ToTable("INV_modelo_dispositivo");

            entity.Property(e => e.IdModeloDispositivo).HasColumnName("id_modelo_dispositivo");
            entity.Property(e => e.ComentarioAuditoria)
                .HasMaxLength(200)
                .HasColumnName("comentario_auditoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvRemplazo>(entity =>
        {
            entity.HasKey(e => e.IdRemplazo).HasName("PK__INV_remp__1C99EED1158AEF47");

            entity.ToTable("INV_remplazo");

            entity.HasIndex(e => e.DispositivoAntiguoId, "IX_INV_remplazo_dispositivo_antiguo_id");

            entity.HasIndex(e => e.DispositivoNuevoId, "IX_INV_remplazo_dispositivo_nuevo_id");

            entity.Property(e => e.IdRemplazo).HasColumnName("id_remplazo");
            entity.Property(e => e.ComentarioRemplazo)
                .HasMaxLength(250)
                .HasColumnName("comentario_remplazo");
            entity.Property(e => e.DispositivoAntiguoId).HasColumnName("dispositivo_antiguo_id");
            entity.Property(e => e.DispositivoNuevoId).HasColumnName("dispositivo_nuevo_id");
            entity.Property(e => e.FechaRemplazo)
                .HasColumnType("datetime")
                .HasColumnName("fecha_remplazo");
            entity.Property(e => e.TipoCambio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipo_cambio");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");

            entity.HasOne(d => d.DispositivoAntiguo).WithMany(p => p.InvRemplazoDispositivoAntiguos)
                .HasForeignKey(d => d.DispositivoAntiguoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_remplazo_dispositivo_antiguo_id");

            entity.HasOne(d => d.DispositivoNuevo).WithMany(p => p.InvRemplazoDispositivoNuevoes)
                .HasForeignKey(d => d.DispositivoNuevoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_remplazo_dispositivo_nuevo_id");
        });

        modelBuilder.Entity<InvResponsiva>(entity =>
        {
            entity.HasKey(e => e.IdResponsiva).HasName("PK__INV_resp__4EECCF779A367602");

            entity.ToTable("INV_responsiva");

            entity.Property(e => e.IdResponsiva).HasColumnName("id_responsiva");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.ResponsivaEstatusId).HasColumnName("responsiva_estatus_id");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
            entity.Property(e => e.UsuarioAsignadoId).HasColumnName("usuario_asignado_id");

            entity.HasOne(d => d.ResponsivaEstatus).WithMany(p => p.InvResponsivas)
                .HasForeignKey(d => d.ResponsivaEstatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_INV_responsiva_estatus_id");
        });

        modelBuilder.Entity<InvTipoAdquisicion>(entity =>
        {
            entity.HasKey(e => e.IdTipoAdquisicion).HasName("PK__INV_tipo__57BFE9331914CD64");

            entity.ToTable("INV_tipo_adquisicion");

            entity.Property(e => e.IdTipoAdquisicion).HasColumnName("id_tipo_adquisicion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
            entity.Property(e => e.UltimaSecuenciaId).HasColumnName("ultima_secuencia_id");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvTipoAlmacenamiento>(entity =>
        {
            entity.HasKey(e => e.IdTipoAlmacenamiento).HasName("PK__INV_tipo__208C396622318AE3");

            entity.ToTable("INV_tipo_almacenamiento");

            entity.Property(e => e.IdTipoAlmacenamiento).HasColumnName("id_tipo_almacenamiento");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvTipoDispositivo>(entity =>
        {
            entity.HasKey(e => e.IdTipoDispositivo).HasName("PK__INV_tipo__FC9464BB142A2A52");

            entity.ToTable("INV_tipo_dispositivo");

            entity.Property(e => e.IdTipoDispositivo).HasColumnName("id_tipo_dispositivo");
            entity.Property(e => e.ComentarioAuditoria)
                .HasMaxLength(200)
                .HasColumnName("comentario_auditoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvTipoHallazgo>(entity =>
        {
            entity.HasKey(e => e.IdTipoHallazgo).HasName("PK__INV_tipo__86F38518A6FB7B75");

            entity.ToTable("INV_tipo_hallazgo");

            entity.Property(e => e.IdTipoHallazgo).HasColumnName("id_tipo_hallazgo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvTipoIncidencia>(entity =>
        {
            entity.HasKey(e => e.IdTipoIncidencia).HasName("PK__INV_tipo__4471446B89B5BEE9");

            entity.ToTable("INV_tipo_incidencia");

            entity.Property(e => e.IdTipoIncidencia).HasColumnName("id_tipo_incidencia");
            entity.Property(e => e.ComentarioAuditoria)
                .HasMaxLength(200)
                .HasColumnName("comentario_auditoria");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        modelBuilder.Entity<InvTipoReporte>(entity =>
        {
            entity.HasKey(e => e.IdTipoReporte).HasName("PK__INV_tipo__6F499D18B56DC631");

            entity.ToTable("INV_tipo_reporte");

            entity.Property(e => e.IdTipoReporte).HasColumnName("id_tipo_reporte");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstatusActivo).HasColumnName("estatus_activo");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("datetime")
                .HasColumnName("fecha_alta");
            entity.Property(e => e.UsuarioAltaId).HasColumnName("usuario_alta_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
