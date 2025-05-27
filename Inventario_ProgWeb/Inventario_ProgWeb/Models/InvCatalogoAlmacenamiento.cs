using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvCatalogoAlmacenamiento
{
    public int IdAlmacenamiento { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string TipoAlmacenamiento { get; set; } = null!;

    public string Capacidad { get; set; } = null!;

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvDispositivoTecnico> InvDispositivoTecnicoes { get; set; } = new List<InvDispositivoTecnico>();
}
