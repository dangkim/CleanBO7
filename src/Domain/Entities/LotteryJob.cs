using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class LotteryJob
{
    public int JobId { get; set; }

    public byte JobType { get; set; }

    public int ProductId { get; set; }

    public bool IsActive { get; set; }

    public byte FrequencyType { get; set; }

    public byte FrequencyValue { get; set; }

    public TimeSpan TimeStart { get; set; }

    public string Sql { get; set; } = null!;
}
