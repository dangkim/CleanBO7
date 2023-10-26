using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class GameBetBundle
{
    public long Id { get; set; }

    public int ProductId { get; set; }

    public long DrawId { get; set; }

    public long MemberUid { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? ClientIp { get; set; }
}
