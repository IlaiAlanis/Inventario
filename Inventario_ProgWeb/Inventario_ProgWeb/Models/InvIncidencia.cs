using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvIncidencia
{
    public int IdIncidencia { get; set; }

    public int DispositivoId { get; set; }

    public int TipoReporteId { get; set; }

    public int EstatusReporteId { get; set; }

    public int TipoIncidenciaId { get; set; }

    public int UbicacionId { get; set; }

    public int DepartamentoId { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public string? NumeroCaso { get; set; }

    public string? Comentario { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual InvDispositivo Dispositivo { get; set; } = null!;

    public virtual InvEstatusReporte EstatusReporte { get; set; } = null!;

    public virtual ICollection<InvIncidenciaHistorial> InvIncidenciaHistorials { get; set; } = new List<InvIncidenciaHistorial>();

    public virtual InvTipoIncidencia TipoIncidencia { get; set; } = null!;

    public virtual InvTipoReporte TipoReporte { get; set; } = null!;

    public virtual InvCatalogoUbicacion Ubicacion { get; set; } = null!;
}
