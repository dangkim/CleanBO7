using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class VendorLimitGroup
{
    public int LimitId { get; set; }

    public int VendorId { get; set; }

    public int GroupId { get; set; }
}
