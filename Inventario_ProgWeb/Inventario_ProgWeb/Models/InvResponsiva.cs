using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvResponsiva
{
    public int IdResponsiva { get; set; }

    public int ResponsivaEstatusId { get; set; }

    public int UsuarioAsignadoId { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public virtual InvEstatusResponsiva ResponsivaEstatus { get; set; } = null!;
}
