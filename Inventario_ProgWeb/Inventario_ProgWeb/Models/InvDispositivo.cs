using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvDispositivo
{
    public int IdDispositivo { get; set; }

    public int TipoDispositivoId { get; set; }

    public int? ModeloDispositivoId { get; set; }

    public int MarcaId { get; set; }

    public int IdSecuencia { get; set; }

    public string IdentificadorDispositivo { get; set; } = null!;

    public string Serie { get; set; } = null!;

    public string? Hostname { get; set; }

    public virtual ICollection<InvAsignacionHistorial> InvAsignacionHistorials { get; set; } = new List<InvAsignacionHistorial>();

    public virtual ICollection<InvAutidoriaDispositivo> InvAutidoriaDispositivoes { get; set; } = new List<InvAutidoriaDispositivo>();

    public virtual InvDispositivoAsignacion? InvDispositivoAsignacion { get; set; }

    public virtual InvDispositivoControl? InvDispositivoControl { get; set; }

    public virtual InvDispositivoFinanciero? InvDispositivoFinanciero { get; set; }

    public virtual ICollection<InvDispositivoHistorial> InvDispositivoHistorials { get; set; } = new List<InvDispositivoHistorial>();

    public virtual InvDispositivoTecnico? InvDispositivoTecnico { get; set; }

    public virtual ICollection<InvIncidencia> InvIncidencias { get; set; } = new List<InvIncidencia>();

    public virtual ICollection<InvLicenciaAsignacion> InvLicenciaAsignacions { get; set; } = new List<InvLicenciaAsignacion>();

    public virtual ICollection<InvRemplazo> InvRemplazoDispositivoAntiguos { get; set; } = new List<InvRemplazo>();

    public virtual ICollection<InvRemplazo> InvRemplazoDispositivoNuevoes { get; set; } = new List<InvRemplazo>();

    public virtual InvCatalogoMarca Marca { get; set; } = null!;

    public virtual InvModeloDispositivo? ModeloDispositivo { get; set; }

    public virtual InvTipoDispositivo TipoDispositivo { get; set; } = null!;
}
