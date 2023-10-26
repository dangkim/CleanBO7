using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class MemberBetProfile
{
    public int ProfileUid { get; set; }

    public int ProductId { get; set; }

    public long MemberUid { get; set; }

    public int ProfileId { get; set; }

    public string Name { get; set; } = null!;

    public string Templates { get; set; } = null!;

    public DateTime UpdatedTime { get; set; }
}
