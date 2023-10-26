using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class VMember
{
    public long MemberUid { get; set; }

    public byte VendorId { get; set; }

    public string MemberId { get; set; } = null!;

    public byte? MemberType { get; set; }

    public string MemberName { get; set; } = null!;

    public byte Language { get; set; }

    public byte Currency { get; set; }

    public decimal Wallet { get; set; }

    public DateTime RegTime { get; set; }

    public DateTime UpdateTime { get; set; }

    public Guid? Token { get; set; }

    public string? TokenM { get; set; }

    public DateTime? LastOnlineTime { get; set; }

    public DateTime? Logoff { get; set; }

    public bool IsKick { get; set; }

    public bool IsLock { get; set; }

    public bool IsOnline { get; set; }

    public bool? IsFun { get; set; }

    public int LoginCount { get; set; }

    public string? ClientIp { get; set; }
}
