using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class AdminRole
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public int? RoleParentId { get; set; }

    public DateTime? RoleSetTime { get; set; }

    public DateTime? RoleUpdateTime { get; set; }

    public int? RoleStatus { get; set; }

    public int? RoleVendorId { get; set; }

    public bool? RoleDefault { get; set; }

    public bool RoleTrader { get; set; }

    public string? RoleLevel { get; set; }
}
