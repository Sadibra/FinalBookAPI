using System;
using System.Collections.Generic;

namespace FinalBookAPI.Models;

public partial class CildTipi
{
    public int Id { get; set; }

    public string? Tip { get; set; }

    public virtual ICollection<Kitab> Kitabs { get; set; } = new List<Kitab>();
}
