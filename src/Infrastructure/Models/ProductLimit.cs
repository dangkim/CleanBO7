using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProductLimit
{
    public int SettingId { get; set; }

    public int GroupId { get; set; }

    public int ProductId { get; set; }

    public int BetTypeUid { get; set; }

    public bool IsSet { get; set; }

    public bool Enabled { get; set; }
}
