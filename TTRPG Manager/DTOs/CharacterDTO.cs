using System;
using System.Collections.Generic;

namespace TTRPG_Manager.DTOs;

public partial class CharacterDTO
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Arquetipo { get; set; }

    public bool EsJugable { get; set; }

    public string Motivacion { get; set; }

    public byte[] Ficha { get; set; }

    public byte[] Imagen { get; set; }

    public byte[] DicPuntos { get; set; }

    public int? PersonaJugadora { get; set; }

    public virtual PlayerDTO PersonaJugadoraNavigation { get; set; }

    public virtual ICollection<AdventureDTO> IdAventuras { get; set; } = new List<AdventureDTO>();
}
