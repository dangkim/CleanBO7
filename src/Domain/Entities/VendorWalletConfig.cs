using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VendorWalletConfig
{
    public int Id { get; set; }

    public string Url { get; set; } = null!;

    public string? HttpContentType { get; set; }

    public string? HttpAcceptType { get; set; }

    public string? HttpMethod { get; set; }

    public string? ApiPaths { get; set; }

    public string? ParamMapKeys { get; set; }

    public string? ResultMapKeys { get; set; }

    public string? MerchantId { get; set; }

    public string? MerchantPassword { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<VendorConfig> VendorConfigs { get; set; } = new List<VendorConfig>();
}
