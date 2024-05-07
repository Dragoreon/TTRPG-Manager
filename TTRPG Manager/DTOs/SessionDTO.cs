using System;
using System.Collections.Generic;

namespace TTRPG_Manager.DTOs;

public partial class SessionDTO
{
    public int Id { get; set; }

    public int NumPartida { get; set; }

    public virtual EntryDTO IdNavigation { get; set; }
}
