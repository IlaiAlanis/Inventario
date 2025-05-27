using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvDispositivoControl
{
    public int DispositivoId { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Comentario { get; set; }

    public virtual InvDispositivo Dispositivo { get; set; } = null!;
}
