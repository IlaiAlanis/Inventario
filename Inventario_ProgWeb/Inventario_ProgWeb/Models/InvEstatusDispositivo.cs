using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvEstatusDispositivo
{
    public int IdEstatusDispositivo { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Descripcion { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvDispositivoAsignacion> InvDispositivoAsignacions { get; set; } = new List<InvDispositivoAsignacion>();
}
