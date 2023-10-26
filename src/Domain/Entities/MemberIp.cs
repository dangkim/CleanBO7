using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class MemberIp
{
    public long Id { get; set; }

    public long MemberUid { get; set; }

    public string Ip { get; set; } = null!;

    public long? LongIp { get; set; }

    public string? PcName { get; set; }

    public DateTime LoginTime { get; set; }

    public string? BrowserLanguage { get; set; }

    public string? Browser { get; set; }

    public string? BrowserVer { get; set; }

    public string? Platform { get; set; }

    public string? UserAgent { get; set; }

    public bool? JavascriptSupport { get; set; }

    public string? JavascriptVersion { get; set; }

    public bool? IsMobile { get; set; }

    public string? MobileDeviceModel { get; set; }

    public string? MobileDeviceManufacturer { get; set; }
}
