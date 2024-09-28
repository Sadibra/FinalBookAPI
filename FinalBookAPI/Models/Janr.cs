using System;
using System.Collections.Generic;

namespace FinalBookAPI.Models;

public partial class Janr
{
    public int Id { get; set; }

    public string? Janr1 { get; set; }

    public virtual ICollection<Kitab> Kitabs { get; set; } = new List<Kitab>();
}
