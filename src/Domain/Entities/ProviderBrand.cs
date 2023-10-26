using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class ProviderBrand
{
    public int Id { get; set; }

    public string BrandName { get; set; } = null!;
}
