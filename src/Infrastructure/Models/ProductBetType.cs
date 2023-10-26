using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProductBetType
{
    public int ProductId { get; set; }

    public int BetTypeUid { get; set; }

    public string? Groupname { get; set; }

    public string Name { get; set; } = null!;

    public int? RelatedId { get; set; }

    public bool Parlay { get; set; }
}
