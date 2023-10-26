using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProductAreaConfig
{
    public int AreaUid { get; set; }

    public int ProductId { get; set; }

    public int AreaId { get; set; }

    public string AreaName { get; set; } = null!;

    public string? AreaNameCn { get; set; }

    public string? AreaNameAlias { get; set; }

    public string? AreaUrl { get; set; }

    public byte AreaStatus { get; set; }

    public int AreaStopBetTime { get; set; }

    public int AreaFrequency { get; set; }

    public int AreaTimeZone { get; set; }

    public string? AreaDrawNoStyle { get; set; }

    public int? AreaResult { get; set; }

    public string? AreaFormat { get; set; }

    public string? PayoutDrawNo { get; set; }

    public int? PayoutBetCount { get; set; }

    public int? PayoutSuccessCount { get; set; }

    public int? PayoutFailedCount { get; set; }

    public int? Dealer { get; set; }

    public bool IsRng { get; set; }

    public int? AreaCancelBetTime { get; set; }

    public int DelayDuration { get; set; }

    public int? DisplayOrder { get; set; }

    public int? PartialResultTime { get; set; }

    public bool? IsAuto { get; set; }

    public TimeSpan? DailyStartTime { get; set; }

    public TimeSpan? DailyEndTime { get; set; }

    public int ResetOffset { get; set; }

    public int TimezoneOffset { get; set; }
}
