using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VendorConfig
{
    public int VendorId { get; set; }

    public int? VendorType { get; set; }

    public string VendorName { get; set; } = null!;

    public string OperatorId { get; set; } = null!;

    public string? SecretKey { get; set; }

    public string? SiteCode { get; set; }

    public bool Status { get; set; }

    public string? CashUrl { get; set; }

    public string? CashUrlExt { get; set; }

    public string? WalletUrl { get; set; }

    public string? MaintenanceLink { get; set; }

    public byte RedirectedProtocol { get; set; }

    public string? CashUrlFile { get; set; }

    public string? AuthUrl { get; set; }

    public string? AuthUrlFile { get; set; }

    public string? AuthUrlExt { get; set; }

    public int? VendorWalletConfigId { get; set; }

    public bool? NotifyEndGame { get; set; }

    public string? AuthParam { get; set; }

    public string? CashParam { get; set; }

    public string? ReportPassword { get; set; }

    public string? ActiveProducts { get; set; }

    public string? FunCurrency { get; set; }

    public int? TrialPromoFor { get; set; }

    public bool? HasLobby { get; set; }

    public virtual ICollection<VendorConfigSideMenuSetting> VendorConfigSideMenuSettings { get; set; } = new List<VendorConfigSideMenuSetting>();

    public virtual VendorWalletConfig? VendorWalletConfig { get; set; }
}
