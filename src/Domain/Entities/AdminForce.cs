using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class AdminForce
{
    public int ForceId { get; set; }

    public string? ForceIpaddress { get; set; }

    public int? ForceCount { get; set; }

    public DateTime? ForceActionTime { get; set; }

    public string? ForceMacAddress { get; set; }
}
