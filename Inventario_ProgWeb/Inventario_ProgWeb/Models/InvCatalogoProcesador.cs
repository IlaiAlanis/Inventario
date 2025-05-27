using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvCatalogoProcesador
{
    public int IdProcesador { get; set; }

    public int UsuarioAltaId { get; set; }

    public int MarcaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string? Descripcion { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvDispositivoTecnico> InvDispositivoTecnicoes { get; set; } = new List<InvDispositivoTecnico>();

    public virtual InvCatalogoMarca Marca { get; set; } = null!;
}
