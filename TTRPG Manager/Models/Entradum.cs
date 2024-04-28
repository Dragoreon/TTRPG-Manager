using System;
using System.Collections.Generic;

namespace TTRPG_Manager.Models;

public partial class Entradum
{
    public int Id { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string Titulo { get; set; }

    public byte[] Contenido { get; set; }

    public string Tipo { get; set; }

    public int? Aventura { get; set; }

    public int? EntradaPadre { get; set; }

    public virtual Aventura AventuraNavigation { get; set; }

    public virtual Entradum EntradaPadreNavigation { get; set; }

    public virtual ICollection<Entradum> InverseEntradaPadreNavigation { get; set; } = new List<Entradum>();

    public virtual ICollection<Partidum> Partida { get; set; } = new List<Partidum>();
}
