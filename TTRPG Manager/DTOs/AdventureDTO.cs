using System;
using System.Collections.Generic;

namespace TTRPG_Manager.DTOs;

public partial class AdventureDTO
{
    public int Id { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string Nombre { get; set; }

    public byte[] Imagen { get; set; }

    public int? IdCampana { get; set; }

    public byte[] ListaEtiquetas { get; set; }

    public bool? EnProceso { get; set; }

    public virtual ICollection<EntryDTO> Entrada { get; set; } = new List<EntryDTO>();

    public virtual CampaignDTO IdCampanaNavigation { get; set; }

    public virtual ICollection<CharacterDTO> IdPersonajes { get; set; } = new List<CharacterDTO>();

    public virtual ICollection<RuleManualDTO> ManualReglas { get; set; } = new List<RuleManualDTO>();
}
