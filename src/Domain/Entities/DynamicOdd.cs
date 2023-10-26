using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class DynamicOdd
{
    public long Id { get; set; }

    public long DrawId { get; set; }

    public string Odds { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
