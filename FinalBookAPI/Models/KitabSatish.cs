using System;
using System.Collections.Generic;

namespace FinalBookAPI.Models;

public partial class KitabSatish
{
    public int Id { get; set; }

    public int? KitabId { get; set; }

    public int? Say { get; set; }

    public DateTime? Tarix { get; set; }

    public virtual Kitab? Kitab { get; set; }
}
