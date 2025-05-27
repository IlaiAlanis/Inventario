using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvDispositivoHistorial
{
    public int IdDispositivoHistorial { get; set; }

    public int DispositivoId { get; set; }

    public int UsuarioResponsableId { get; set; }

    public DateTime FechaEvento { get; set; }

    public string? CampoModificado { get; set; }

    public string? ValorAnterior { get; set; }

    public string? ValorNuevo { get; set; }

    public string? Comentario { get; set; }

    public virtual InvDispositivo Dispositivo { get; set; } = null!;
}
