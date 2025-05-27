using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvCatalogoRam
{
    public int IdRam { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Descripcion { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvDispositivoTecnico> InvDispositivoTecnicoes { get; set; } = new List<InvDispositivoTecnico>();
}
