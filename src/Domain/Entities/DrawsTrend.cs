﻿using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class DrawsTrend
{
    public long DrawId { get; set; }

    public string TrendKey { get; set; } = null!;

    public string TrendValue { get; set; } = null!;

    public string? Hotgap { get; set; }
}
