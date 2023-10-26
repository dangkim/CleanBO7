using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProductLimitGroup
{
    public int GroupId { get; set; }

    public string Name { get; set; } = null!;

    public string Remarks { get; set; } = null!;
}
