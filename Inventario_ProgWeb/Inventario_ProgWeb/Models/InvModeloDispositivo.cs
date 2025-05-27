using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvModeloDispositivo
{
    public int IdModeloDispositivo { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Descripcion { get; set; }

    public string ComentarioAuditoria { get; set; } = null!;

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvDispositivo> InvDispositivoes { get; set; } = new List<InvDispositivo>();
}
