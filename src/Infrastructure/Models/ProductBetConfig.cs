using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProductBetConfig
{
    public int ConfigId { get; set; }

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

    public string? MaxWinning { get; set; }
}
