using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class CurrenciesRateDetail
{
    public int Id { get; set; }

    public byte CurrencyId { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? LastUpdateTime { get; set; }
}
