using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VendorWalletProductConfig
{
    public int Id { get; set; }

    public int VendorWalletConfigId { get; set; }

    public string? ProductCode { get; set; }
}
