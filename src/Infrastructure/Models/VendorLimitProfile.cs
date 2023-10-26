using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class VendorLimitProfile
{
    public int ProfileId { get; set; }

    public int ProductId { get; set; }

    public string ProfileName { get; set; } = null!;

    public string ProfileVendors { get; set; } = null!;
}
