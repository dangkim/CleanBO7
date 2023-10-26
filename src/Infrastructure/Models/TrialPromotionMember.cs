using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class TrialPromotionMember
{
    public long Id { get; set; }

    public int PromoId { get; set; }

    public long MemberUid { get; set; }

    public decimal Balance { get; set; }

    public bool RewardRedeemed { get; set; }

    public byte[] RowTimestamp { get; set; } = null!;
}
