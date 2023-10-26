using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class VendorWalletProductConfig
{
    public int Id { get; set; }

    public int VendorWalletConfigId { get; set; }

    public string? ProductCode { get; set; }
}
