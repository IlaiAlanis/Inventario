using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvLicenciaRenovacion
{
    public int IdLicenciaRenovacion { get; set; }

    public int LicenciaAsignacionId { get; set; }

    public int? UsuarioAsignacionId { get; set; }

    public int? UsuarioAltaId { get; set; }

    public DateTime FechaRenovacion { get; set; }

    public DateTime? FechaNuevoVencimiento { get; set; }

    public string? Comentario { get; set; }

    public virtual InvLicenciaAsignacion LicenciaAsignacion { get; set; } = null!;
}
