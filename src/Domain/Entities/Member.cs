using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class Member
{
    public long MemberUid { get; set; }

    public int VendorId { get; set; }

    public string MemberId { get; set; } = null!;

    public byte? MemberType { get; set; }

    public bool? IsFun { get; set; }

    public DateTime RegTime { get; set; }

    public bool IsTest { get; set; }

    public string? MWalletId { get; set; }
}
