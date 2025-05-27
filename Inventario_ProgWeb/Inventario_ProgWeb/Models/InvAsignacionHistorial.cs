using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvAsignacionHistorial
{
    public int IdAsignacionHistorial { get; set; }

    public int DispositivoId { get; set; }

    public int UsuarioId { get; set; }

    public int DepartamentoId { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public DateTime FechaDesasignacion { get; set; }

    public virtual InvDispositivo Dispositivo { get; set; } = null!;
}
