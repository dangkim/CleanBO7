using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VendorLimitProfileSetting
{
    public int ConfigId { get; set; }

    public int ProfileId { get; set; }

    public int BetTypeUid { get; set; }

    public string StakeMin { get; set; } = null!;

    public string StakeMax { get; set; } = null!;
}
