using System;
using System.Collections.Generic;

namespace TTRPG_Manager.DTOs;

public partial class CampaignDTO
{
    public int Id { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string Nombre { get; set; }

    public bool EnProceso { get; set; }

    public virtual ICollection<AdventureDTO> Aventuras { get; set; } = new List<AdventureDTO>();
}
