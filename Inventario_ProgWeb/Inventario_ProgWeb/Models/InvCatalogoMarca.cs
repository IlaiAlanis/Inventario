using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvCatalogoMarca
{
    public int IdMarca { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Descripcion { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvCatalogoProcesador> InvCatalogoProcesadors { get; set; } = new List<InvCatalogoProcesador>();

    public virtual ICollection<InvDispositivo> InvDispositivoes { get; set; } = new List<InvDispositivo>();
}
