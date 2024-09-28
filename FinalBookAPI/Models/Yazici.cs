using System;
using System.Collections.Generic;

namespace FinalBookAPI.Models;

public partial class Yazici
{
    public int Id { get; set; }

    public string? Yazici1 { get; set; }

    public virtual ICollection<Kitab> Kitabs { get; set; } = new List<Kitab>();
}
