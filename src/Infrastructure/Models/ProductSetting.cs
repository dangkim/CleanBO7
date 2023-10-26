using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProductSetting
{
    public int SettingId { get; set; }

    public int ProductId { get; set; }

    public int LimitId { get; set; }

    public string? Multiplier { get; set; }

    public int? Timeout { get; set; }
}
