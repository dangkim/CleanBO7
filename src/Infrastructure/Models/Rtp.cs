using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class Rtp
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public DateTime Date { get; set; }

    public int AreaId { get; set; }

    public int? BetTypeUid { get; set; }

    public decimal? TotalBetAmount { get; set; }

    public int? TotalHitCount { get; set; }

    public decimal? TotalWinAmount { get; set; }
}
