using System;
using System.Collections.Generic;

namespace TTRPG_Manager.DTOs;

public partial class PlayerDTO
{
    public int Id { get; set; }

    public string Apodo { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public string Objetivo { get; set; }

    public string Contacto { get; set; }

    public byte[] Etiquetas { get; set; }

    public virtual ICollection<CharacterDTO> Personajes { get; set; } = new List<CharacterDTO>();
}
