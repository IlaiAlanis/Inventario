using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvDispositivoAsignacion
{
    public int DispositivoId { get; set; }

    public int UbicacionId { get; set; }

    public int? DepartamentoId { get; set; }

    public int UsuarioAsignadoId { get; set; }

    public int EstatusDispositivoId { get; set; }

    public int? ResponsivaId { get; set; }

    public virtual InvDispositivo Dispositivo { get; set; } = null!;

    public virtual InvEstatusDispositivo EstatusDispositivo { get; set; } = null!;

    public virtual InvCatalogoUbicacion Ubicacion { get; set; } = null!;
}
