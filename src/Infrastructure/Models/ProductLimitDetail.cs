using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProductLimitDetail
{
    public int DetailId { get; set; }

    public int SettingId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string Limit { get; set; } = null!;
}
