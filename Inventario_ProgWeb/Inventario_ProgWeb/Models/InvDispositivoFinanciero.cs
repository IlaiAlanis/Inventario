using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvDispositivoFinanciero
{
    public int DispositivoId { get; set; }

    public int FacturaId { get; set; }

    public int? RemplazoId { get; set; }

    public DateTime FechaAdquisicion { get; set; }

    public DateTime FechaInicioGarantia { get; set; }

    public DateTime FechaFinGarantia { get; set; }

    public decimal Costo { get; set; }

    public string? Contrato { get; set; }

    public virtual InvDispositivo Dispositivo { get; set; } = null!;

    public virtual InvFactura Factura { get; set; } = null!;

    public virtual InvRemplazo? Remplazo { get; set; }
}
