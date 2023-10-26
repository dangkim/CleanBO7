using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VendorDomainFe
{
    public int DomainAutoId { get; set; }

    public int DomainVendorId { get; set; }

    public string DomainName { get; set; } = null!;

    public bool DomainSecure { get; set; }

    public bool? IsMobileHtml { get; set; }
}
