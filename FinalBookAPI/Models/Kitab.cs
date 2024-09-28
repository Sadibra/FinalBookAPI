using System;
using System.Collections.Generic;

namespace FinalBookAPI.Models;

public partial class Kitab
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public int? Say { get; set; }

    public double? Qiymet { get; set; }

    public int? CildTipiId { get; set; }

    public int? JanrId { get; set; }

    public int? NesriyyatId { get; set; }

    public int? DilId { get; set; }

    public int? YaziciId { get; set; }

    public int? TercumeciId { get; set; }

    public DateTime? Tarix { get; set; }

    public byte[]? BookImg { get; set; }

    public virtual CildTipi? CildTipi { get; set; }

    public virtual Dil? Dil { get; set; }

    public virtual Janr? Janr { get; set; }

    public virtual ICollection<KitabSatish> KitabSatishes { get; set; } = new List<KitabSatish>();

    public virtual Nesriyyat? Nesriyyat { get; set; }

    public virtual Tercumeci? Tercumeci { get; set; }

    public virtual Yazici? Yazici { get; set; }
}
