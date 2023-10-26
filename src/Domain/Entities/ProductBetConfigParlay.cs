using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class ProductBetConfigParlay
{
    public int ParlayAutoId { get; set; }

    public int ParlayProductId { get; set; }

    public int ParlayVendorId { get; set; }

    public decimal ParlayOdds { get; set; }

    public decimal ParlayMin { get; set; }

    public decimal ParlayMax { get; set; }
}
