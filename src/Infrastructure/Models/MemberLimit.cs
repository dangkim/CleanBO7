using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class MemberLimit
{
    public long LimitId { get; set; }

    public int LimitVendorId { get; set; }

    public long LimitMemberUid { get; set; }

    public int LimitProductId { get; set; }

    public bool? PassCurrencyRestriction { get; set; }

    public int? Profile { get; set; }

    public int? SelectedLimit { get; set; }

    public string? Remark { get; set; }

    public int? GroupId { get; set; }
}
