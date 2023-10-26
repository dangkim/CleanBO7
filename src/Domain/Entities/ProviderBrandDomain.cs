using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class ProviderBrandDomain
{
    public int BrandId { get; set; }

    public string Domain { get; set; } = null!;
}
