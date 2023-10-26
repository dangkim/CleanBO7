using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class LimitHistory
{
    public string Msg { get; set; } = null!;

    public DateTime MsgTime { get; set; }
}
