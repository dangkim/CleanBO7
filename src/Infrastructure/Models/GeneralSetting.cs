﻿using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class GeneralSetting
{
    public int GeneralAutoId { get; set; }

    public string GeneralKey { get; set; } = null!;

    public string GeneralValue { get; set; } = null!;

    public bool? Active { get; set; }
}
