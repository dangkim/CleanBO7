using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class Draw
{
    public long DrawId { get; set; }

    public int ProductId { get; set; }

    public int AreaId { get; set; }

    public string DrawNo { get; set; } = null!;

    public int TimeZone { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public DateTime CreateTime { get; set; }

    public int? CancelBetTime { get; set; }

    public string? TrendValue { get; set; }

    public string? ExtraData { get; set; }

    public string? Internaldata { get; set; }
}
