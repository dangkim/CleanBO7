using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class AdminLevel
{
    public int LevelId { get; set; }

    public string? LevelNo { get; set; }

    public string? LevelName { get; set; }

    public string? LevelPath { get; set; }

    public string? LevelExplain { get; set; }

    public DateTime? LevelSetTime { get; set; }

    public string? LevelVendorId { get; set; }
}
