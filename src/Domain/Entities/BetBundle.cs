using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class BetBundle
{
    public long Id { get; set; }

    public int ProductId { get; set; }

    public int DrawId { get; set; }

    public int VendorId { get; set; }

    public int MemberUid { get; set; }

    public byte Currency { get; set; }

    public string? ReferenceNo { get; set; }

    public DateTime? CreatedAt { get; set; }
}
