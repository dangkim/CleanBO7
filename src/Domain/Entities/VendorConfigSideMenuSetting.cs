using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VendorConfigSideMenuSetting
{
    public int Id { get; set; }

    public int VendorId { get; set; }

    public int ProductId { get; set; }

    public virtual VendorConfig Vendor { get; set; } = null!;
}
