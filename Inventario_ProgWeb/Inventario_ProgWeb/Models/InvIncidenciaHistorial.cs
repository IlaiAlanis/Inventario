using System;
using System.Collections.Generic;

namespace Inventario_ProgWeb.Models;

public partial class InvIncidenciaHistorial
{
    public int IdIncidenciaHistorial { get; set; }

    public int IncidenciaId { get; set; }

    public int UsuarioAltaId { get; set; }

    public DateTime FechaEvento { get; set; }

    public string? CampoModificado { get; set; }

    public string? ValorAnterior { get; set; }

    public string? ValorNuevo { get; set; }

    public string? Comentario { get; set; }

    public virtual InvIncidencia Incidencia { get; set; } = null!;
}
