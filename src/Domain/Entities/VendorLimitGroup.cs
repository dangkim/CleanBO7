using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VendorLimitGroup
{
    public int LimitId { get; set; }

    public int VendorId { get; set; }

    public int GroupId { get; set; }
}
