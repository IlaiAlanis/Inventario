using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvCatalogoLicencia
{
    public int IdCatalogoLicencia { get; set; }

    public int ProveedorId { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Version { get; set; }

    public string Tipo { get; set; } = null!;

    public string? ClaveLicencia { get; set; }

    public int? CantidadTotal { get; set; }

    public string? Comentario { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvLicenciaAsignacion> InvLicenciaAsignacions { get; set; } = new List<InvLicenciaAsignacion>();

    public virtual InvCatalogoProveedor Proveedor { get; set; } = null!;
}
