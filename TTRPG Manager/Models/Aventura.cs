using System;
using System.Collections.Generic;

namespace TTRPG_Manager.Models;

public partial class Aventura
{
    public int Id { get; set; }

    public DateTime FechaCreacion { get; set; }

    public string Nombre { get; set; }

    public byte[] Imagen { get; set; }

    public int? IdCampana { get; set; }

    public byte[] ListaEtiquetas { get; set; }

    public bool? EnProceso { get; set; }

    public virtual ICollection<Entradum> Entrada { get; set; } = new List<Entradum>();

    public virtual Campana IdCampanaNavigation { get; set; }

    public virtual ICollection<Personaje> IdPersonajes { get; set; } = new List<Personaje>();

    public virtual ICollection<ManualRegla> ManualReglas { get; set; } = new List<ManualRegla>();
}
