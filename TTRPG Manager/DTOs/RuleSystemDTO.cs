using System;
using System.Collections.Generic;

namespace TTRPG_Manager.DTOs;

public partial class RuleSystemDTO
{
    public string Nombre { get; set; }

    public string Edicion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string Clase { get; set; }

    public byte[] ListaEtiquetas { get; set; }

    public virtual ICollection<RuleManualDTO> ManualReglas { get; set; } = new List<RuleManualDTO>();
}
