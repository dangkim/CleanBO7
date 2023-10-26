using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class SysLog
{
    public int LogId { get; set; }

    public int LogProductId { get; set; }

    public int LogVendorId { get; set; }

    public long? LogDrawId { get; set; }

    public byte LogType { get; set; }

    public string? LogContent { get; set; }

    public DateTime LogTime { get; set; }

    public int LogAdminId { get; set; }

    public string? LogClientIp { get; set; }
}
