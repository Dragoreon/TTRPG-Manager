using System;
using System.Collections.Generic;

namespace TTRPG_Manager.DTOs;

public partial class EntryDTO
{
    public int Id { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string Titulo { get; set; }

    public byte[] Contenido { get; set; }

    public string Tipo { get; set; }

    public int? Aventura { get; set; }

    public int? EntradaPadre { get; set; }

    public virtual AdventureDTO AventuraNavigation { get; set; }

    public virtual EntryDTO EntradaPadreNavigation { get; set; }

    public virtual ICollection<EntryDTO> InverseEntradaPadreNavigation { get; set; } = new List<EntryDTO>();

    public virtual ICollection<SessionDTO> Partida { get; set; } = new List<SessionDTO>();
}
