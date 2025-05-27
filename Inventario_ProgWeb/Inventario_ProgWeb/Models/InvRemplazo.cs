using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvRemplazo
{
    public int IdRemplazo { get; set; }

    public int DispositivoAntiguoId { get; set; }

    public int DispositivoNuevoId { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaRemplazo { get; set; }

    public string TipoCambio { get; set; } = null!;

    public string? ComentarioRemplazo { get; set; }

    public virtual InvDispositivo DispositivoAntiguo { get; set; } = null!;

    public virtual InvDispositivo DispositivoNuevo { get; set; } = null!;

    public virtual ICollection<InvDispositivoFinanciero> InvDispositivoFinancieroes { get; set; } = new List<InvDispositivoFinanciero>();
}
