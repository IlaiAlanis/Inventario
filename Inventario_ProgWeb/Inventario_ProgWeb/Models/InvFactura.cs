using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvFactura
{
    public int IdFactura { get; set; }

    public int ProveedorId { get; set; }

    public int AdquisicionId { get; set; }

    public DateTime FechaTimbrado { get; set; }

    public string Uuid { get; set; } = null!;

    public decimal Total { get; set; }

    public string? Descripcion { get; set; }

    public short CantidadDispositivo { get; set; }

    public short CantidadDispositivoAsignado { get; set; }

    public string? RutaPdf { get; set; }

    public string? RutaXml { get; set; }

    public virtual InvTipoAdquisicion Adquisicion { get; set; } = null!;

    public virtual ICollection<InvDispositivoFinanciero> InvDispositivoFinancieroes { get; set; } = new List<InvDispositivoFinanciero>();

    public virtual InvCatalogoProveedor Proveedor { get; set; } = null!;
}
