using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvTipoReporte
{
    public int IdTipoReporte { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Descripcion { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvIncidencia> InvIncidencias { get; set; } = new List<InvIncidencia>();
}
