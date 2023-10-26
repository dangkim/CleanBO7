using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class GameBet
{
    public long Id { get; set; }

    public long BundleId { get; set; }

    public long DrawId { get; set; }

    public long MemberUid { get; set; }

    public int CurrencyId { get; set; }

    public int Status { get; set; }

    public decimal Rate { get; set; }

    public int Count { get; set; }

    public decimal Stake { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal? PayoutAmount { get; set; }

    public int TypeId { get; set; }

    public string Content { get; set; } = null!;

    public string Odds { get; set; } = null!;

    public byte Platform { get; set; }

    public DateTime CreatedTime { get; set; }

    public DateTime? DoneTime { get; set; }
}
