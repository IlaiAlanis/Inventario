using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvCatalogoProveedor
{
    public int IdCatalogoProveedor { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaAlta { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Rfc { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public string? SitioWeb { get; set; }

    public string? Direccion { get; set; }

    public string? Comentario { get; set; }

    public bool EstatusActivo { get; set; }

    public virtual ICollection<InvCatalogoLicencia> InvCatalogoLicencias { get; set; } = new List<InvCatalogoLicencia>();

    public virtual ICollection<InvFactura> InvFacturas { get; set; } = new List<InvFactura>();
}
