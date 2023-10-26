using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class RiskBalancerTracking
{
    public int Id { get; set; }

    public int DrawId { get; set; }

    public int VendorId { get; set; }

    public int BetType { get; set; }

    public string BetContent { get; set; } = null!;

    public int ActiveRange { get; set; }

    public decimal? Odds { get; set; }

    public decimal? TotalRmbamount { get; set; }
}
