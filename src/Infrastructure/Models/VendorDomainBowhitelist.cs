using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class VendorDomainBowhitelist
{
    public long WhiteListId { get; set; }

    public int WhiteListVendorId { get; set; }

    public string WhiteListIp { get; set; } = null!;

    public string WhiteListSubnet { get; set; } = null!;

    public string? WhiteListDesc { get; set; }
}
