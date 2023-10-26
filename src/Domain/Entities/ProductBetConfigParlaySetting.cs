using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class ProductBetConfigParlaySetting
{
    public int ParlayAutoId { get; set; }

    public int ParlayProductId { get; set; }

    public int ParlayVendorId { get; set; }

    public decimal ParlayPayoutConfirm { get; set; }

    public decimal ParlayOddsCoefficient { get; set; }

    public DateTime ParlayCreateTime { get; set; }

    public DateTime? ParlayUpdateTime { get; set; }
}
