using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class GeneralSetting
{
    public int GeneralAutoId { get; set; }

    public string GeneralKey { get; set; } = null!;

    public string GeneralValue { get; set; } = null!;

    public bool? Active { get; set; }
}
