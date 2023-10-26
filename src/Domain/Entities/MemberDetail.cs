using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class MemberDetail
{
    public long DetailMemberUid { get; set; }

    public string MemberName { get; set; } = null!;

    public byte Language { get; set; }

    public byte Currency { get; set; }

    public decimal Wallet { get; set; }

    public DateTime UpdateTime { get; set; }

    public Guid? Token { get; set; }

    public string? TokenM { get; set; }

    public DateTime? LastOnlineTime { get; set; }

    public DateTime? Logoff { get; set; }

    public bool IsKick { get; set; }

    public bool IsLock { get; set; }

    public bool IsOnline { get; set; }

    public int LoginCount { get; set; }

    public string? ClientIp { get; set; }

    public string? ReservedValue { get; set; }
}
