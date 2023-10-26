using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class CurrenciesRateDetail
{
    public int Id { get; set; }

    public byte CurrencyId { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? LastUpdateTime { get; set; }
}
