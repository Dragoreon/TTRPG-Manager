using System;
using System.Collections.Generic;

namespace TTRPG_Manager.DTOs;

public partial class RuleManualDTO
{
    public int Id { get; set; }

    public string Titulo { get; set; }

    public string NombreSistema { get; set; }

    public string EdicionSistema { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string Tipo { get; set; }

    public byte[] Archivo { get; set; }

    public byte[] DicBookmarks { get; set; }

    public virtual RuleSystemDTO Sistema { get; set; }

    public virtual ICollection<AdventureDTO> Aventuras { get; set; } = new List<AdventureDTO>();
}
