using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvInventarioParcial
{
    public int IdInventarioParcial { get; set; }

    public int InventarioBaseId { get; set; }

    public int DepartamentoId { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvAutidoriaDispositivo> InvAutidoriaDispositivoes { get; set; } = new List<InvAutidoriaDispositivo>();
}
