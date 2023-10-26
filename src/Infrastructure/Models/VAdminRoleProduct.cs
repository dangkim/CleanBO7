using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class VAdminRoleProduct
{
    public int AdminId { get; set; }

    public int AdminVendorId { get; set; }

    public string AdminUsername { get; set; } = null!;

    public string AdminRealName { get; set; } = null!;

    public int AdminRole { get; set; }

    public string? RoleName { get; set; }

    public int AdminSuperior { get; set; }

    public byte AdminStatus { get; set; }

    public DateTime AdminRegTime { get; set; }

    public DateTime? AdminLoginTime { get; set; }

    public DateTime? AdminLogoutTime { get; set; }

    public string? AdminLoginIp { get; set; }

    public DateTime? AdminUpdateTime { get; set; }

    public string AdminMail { get; set; } = null!;

    public int AdminForceAttempt { get; set; }

    public int ProductId { get; set; }

    public bool RoleTrader { get; set; }
}
