using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvLicenciaAsignacion
{
    public int IdLicenciaAsignacion { get; set; }

    public int CatalogoLicenciaId { get; set; }

    public int? DispositivoId { get; set; }

    public int? UsuarioAsignacionId { get; set; }

    public int? UsuarioAltaId { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public DateTime? FechaExpiracion { get; set; }

    public string? ClaveAsignada { get; set; }

    public virtual InvCatalogoLicencia CatalogoLicencia { get; set; } = null!;

    public virtual InvDispositivo? Dispositivo { get; set; }

    public virtual ICollection<InvLicenciaRenovacion> InvLicenciaRenovacions { get; set; } = new List<InvLicenciaRenovacion>();
}
