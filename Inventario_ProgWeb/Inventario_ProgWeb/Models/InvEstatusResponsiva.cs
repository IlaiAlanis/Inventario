using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvEstatusResponsiva
{
    public int IdEstatusResponsiva { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Descripcion { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvResponsiva> InvResponsivas { get; set; } = new List<InvResponsiva>();
}
