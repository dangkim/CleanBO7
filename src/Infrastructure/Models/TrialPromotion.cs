using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class TrialPromotion
{
    public int Id { get; set; }

    public string PromoName { get; set; } = null!;

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int VendorId { get; set; }

    public string BannerUrl { get; set; } = null!;
}
