using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class DrawSummaryDetail
{
    public int? DrawId { get; set; }

    public int? BetTypeUid { get; set; }

    public int? PlatformOs { get; set; }

    public int? VendorId { get; set; }

    public long Id { get; set; }
}
