using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class DigitRiskBalancer
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? VendorId { get; set; }

    public int? BetTypeUid { get; set; }

    public string? Config { get; set; }
}
