using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VCurrency
{
    public long? Rno { get; set; }

    public byte CurrencyId { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? EffectiveDate { get; set; }
}
