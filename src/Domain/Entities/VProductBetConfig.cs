using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VProductBetConfig
{
    public int ProductId { get; set; }

    public int VendorId { get; set; }

    public int AreaId { get; set; }

    public int BetTypeUid { get; set; }

    public string? Odds { get; set; }

    public string? StakeMin { get; set; }

    public string? StakeMax { get; set; }

    public decimal? UserLimit { get; set; }

    public decimal? AutoBalance { get; set; }

    public decimal? GlobalLimit { get; set; }

    public string? CanBet { get; set; }

    public string Name { get; set; } = null!;

    public string? Groupname { get; set; }

    public int? RelatedId { get; set; }

    public bool Parlay { get; set; }
}
