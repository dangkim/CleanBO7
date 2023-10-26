using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class Admin
{
    public int AdminId { get; set; }

    public int AdminVendorId { get; set; }

    public string AdminUsername { get; set; } = null!;

    public string AdminPassword { get; set; } = null!;

    public string AdminRealName { get; set; } = null!;

    public int AdminRole { get; set; }

    public int AdminSuperior { get; set; }

    public byte AdminStatus { get; set; }

    public DateTime AdminRegTime { get; set; }

    public DateTime? AdminLoginTime { get; set; }

    public DateTime? AdminLogoutTime { get; set; }

    public string? AdminLoginIp { get; set; }

    public DateTime? AdminUpdateTime { get; set; }

    public string AdminMail { get; set; } = null!;

    public int? AdminForceAttempt { get; set; }

    public string? AdminActivation { get; set; }

    public bool? AdminDefault { get; set; }

    public int? AdminDefaultProduct { get; set; }

    public bool IsCas { get; set; }
}
