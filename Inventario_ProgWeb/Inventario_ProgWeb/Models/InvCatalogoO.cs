using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvCatalogoO
{
    public int IdOs { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string Descripcion { get; set; } = null!;

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvDispositivoTecnico> InvDispositivoTecnicoes { get; set; } = new List<InvDispositivoTecnico>();
}
