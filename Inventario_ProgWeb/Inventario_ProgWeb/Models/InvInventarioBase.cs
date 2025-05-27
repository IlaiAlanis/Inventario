using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvInventarioBase
{
    public int IdInventarioBase { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public bool EstatusActivo { get; set; }
}
