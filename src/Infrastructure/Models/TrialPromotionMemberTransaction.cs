using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class TrialPromotionMemberTransaction
{
    public long Id { get; set; }

    public int PromoMemberId { get; set; }

    public string TrxRefNo { get; set; } = null!;

    public int TrxType { get; set; }

    public decimal Amount { get; set; }

    public decimal BeforeBal { get; set; }

    public decimal AfterBal { get; set; }

    public int GameId { get; set; }

    public DateTime? TrxTime { get; set; }
}
