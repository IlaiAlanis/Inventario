using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvTipoAlmacenamiento
{
    public int IdTipoAlmacenamiento { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Descripcion { get; set; }

    public bool EstatusActivo { get; set; }
}
