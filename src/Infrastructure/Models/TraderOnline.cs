using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class TraderOnline
{
    public int TraderOnlineId { get; set; }

    public int TraderProductId { get; set; }

    public int TraderAdminId { get; set; }

    public int TraderAreaUid { get; set; }

    public DateTime? TraderInTime { get; set; }

    public DateTime? TraderActiveTime { get; set; }

    public bool? TraderPlatform { get; set; }
}
