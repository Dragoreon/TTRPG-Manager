using System;
using System.Collections.Generic;

namespace TTRPG_Manager.Models;

public partial class Partidum
{
    public int Id { get; set; }

    public int NumPartida { get; set; }

    public virtual Entradum IdNavigation { get; set; }
}
