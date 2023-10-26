using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProviderBrandDomain
{
    public int BrandId { get; set; }

    public string Domain { get; set; } = null!;
}
