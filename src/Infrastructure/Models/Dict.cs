using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class Dict
{
    public long DictId { get; set; }

    public byte DictNo { get; set; }

    public string? DictColumn { get; set; }

    public string? DictExplain { get; set; }
}
