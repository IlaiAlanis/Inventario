using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvDispositivoTecnico
{
    public int DispositivoId { get; set; }

    public int ProcesadorId { get; set; }

    public int? RamId { get; set; }

    public int? AlmacenamientoId { get; set; }

    public int OsId { get; set; }

    public string Mac { get; set; } = null!;

    public virtual InvCatalogoAlmacenamiento? Almacenamiento { get; set; }

    public virtual InvDispositivo Dispositivo { get; set; } = null!;

    public virtual InvCatalogoO Os { get; set; } = null!;

    public virtual InvCatalogoProcesador Procesador { get; set; } = null!;

    public virtual InvCatalogoRam? Ram { get; set; }
}
