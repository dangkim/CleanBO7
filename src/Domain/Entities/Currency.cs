using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class Currency
{
    public byte CurrencyId { get; set; }

    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public DateTime UpdateTime { get; set; }
}
