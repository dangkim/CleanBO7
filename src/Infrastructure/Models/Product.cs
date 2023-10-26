using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCode { get; set; }

    public string GameCode { get; set; } = null!;

    public bool? Active { get; set; }

    public string? DisplayName { get; set; }

    public string? ParamName { get; set; }

    public string? CustomConfig { get; set; }

    public int BrandId { get; set; }
}
