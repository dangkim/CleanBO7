using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class TrialPromotionCurrency
{
    public int PromoId { get; set; }

    public string Currency { get; set; } = null!;

    public decimal InitialBalance { get; set; }
}
