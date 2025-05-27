using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvTipoAdquisicion
{
    public int IdTipoAdquisicion { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public int? UltimaSecuenciaId { get; set; }

    public string Nombre { get; set; } = null!;

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvFactura> InvFacturas { get; set; } = new List<InvFactura>();
}
