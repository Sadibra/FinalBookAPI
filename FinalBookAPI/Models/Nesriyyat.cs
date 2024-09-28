using System;
using System.Collections.Generic;

namespace FinalBookAPI.Models;

public partial class Nesriyyat
{
    public int Id { get; set; }

    public string? Nesriyyat1 { get; set; }

    public virtual ICollection<Kitab> Kitabs { get; set; } = new List<Kitab>();
}
