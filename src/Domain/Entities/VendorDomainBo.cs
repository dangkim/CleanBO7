using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VendorDomainBo
{
    public int DomainAutoId { get; set; }

    public int DomainVendorId { get; set; }

    public string? DomainName { get; set; }

    public string? CasHost { get; set; }
}
