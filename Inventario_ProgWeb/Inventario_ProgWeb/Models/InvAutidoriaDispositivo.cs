using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvAutidoriaDispositivo
{
    public int IdAuditoriaDispositivo { get; set; }

    public int InventarioParcialId { get; set; }

    public int DispositivoId { get; set; }

    public int HallazgoId { get; set; }

    public DateTime FechaAdquisicion { get; set; }

    public DateTime? FechaInicioGarantia { get; set; }

    public DateTime? FechaFinGarantia { get; set; }

    public int? MarcaId { get; set; }

    public int? ModeloDispositivoId { get; set; }

    public int UbicacionId { get; set; }

    public int? ProcesadorId { get; set; }

    public int? OsId { get; set; }

    public int? AlmacenamientoId { get; set; }

    public int? RamId { get; set; }

    public int? DepartamentoId { get; set; }

    public int UsuarioAsignadoId { get; set; }

    public string IdentificadorDispositivo { get; set; } = null!;

    public string? Hostname { get; set; }

    public string? Serie { get; set; }

    public string? Mac { get; set; }

    public decimal? Costo { get; set; }

    public string? AuditoriaComentario { get; set; }

    public bool AudititoriaAceptado { get; set; }

    public virtual InvDispositivo Dispositivo { get; set; } = null!;

    public virtual InvTipoHallazgo Hallazgo { get; set; } = null!;

    public virtual InvInventarioParcial InventarioParcial { get; set; } = null!;
}
