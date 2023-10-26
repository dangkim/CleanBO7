using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProductAreaConfigRule
{
    public int ProductId { get; set; }

    public int AreaId { get; set; }

    public int Order { get; set; }

    public string Start { get; set; } = null!;

    public string? AddDayFormat { get; set; }

    public int? FrequencyOverride { get; set; }

    public string? StartDay { get; set; }

    public string? StartNo { get; set; }

    public string StartTime { get; set; } = null!;

    public string EndTime { get; set; } = null!;

    public string? Style { get; set; }

    public string? Version { get; set; }

    public bool? Active { get; set; }
}
