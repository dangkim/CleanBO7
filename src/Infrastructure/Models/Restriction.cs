using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class Restriction
{
    public int RestrictionId { get; set; }

    public int DrawId { get; set; }

    public int BetTypeUid { get; set; }

    public string BetContent { get; set; } = null!;

    public string Odds { get; set; } = null!;

    public int BetsLimit { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public DateTime CreatedTime { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? UpdatedBy { get; set; }

    public int? BetsCount { get; set; }
}
