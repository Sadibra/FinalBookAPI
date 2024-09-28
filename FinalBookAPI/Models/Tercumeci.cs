using System;
using System.Collections.Generic;

namespace FinalBookAPI.Models;

public partial class Tercumeci
{
    public int Id { get; set; }

    public string? Tercumeci1 { get; set; }

    public virtual ICollection<Kitab> Kitabs { get; set; } = new List<Kitab>();
}
