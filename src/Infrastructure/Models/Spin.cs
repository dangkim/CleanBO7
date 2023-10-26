using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class Spin
{
    public long SpinId { get; set; }

    public long BundleId { get; set; }

    public int ProductId { get; set; }

    public long MemberUid { get; set; }

    public string? Metadata { get; set; }

    public string? Result { get; set; }

    public int Step { get; set; }

    public string Content { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int Status { get; set; }

    public short Currency { get; set; }

    public decimal? ExchangeRate { get; set; }

    public decimal Stake { get; set; }

    public decimal? PayoutAmount { get; set; }

    public string ClientIp { get; set; } = null!;

    public byte Platform { get; set; }

    public bool StartedNext { get; set; }
}
