using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class ProductRestriction
{
    public int RestrictionId { get; set; }

    public int RestrictionProductId { get; set; }

    public int RestrictionVendorId { get; set; }

    public byte RestrictionCurrencyId { get; set; }
}
