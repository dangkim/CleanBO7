using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class MemberLimitProfile
{
    public int ProfileId { get; set; }

    public int ProfileProductId { get; set; }

    public int ProfileVendorId { get; set; }

    public string? ProfileName { get; set; }
}
