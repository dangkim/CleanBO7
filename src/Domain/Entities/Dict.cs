using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class Dict
{
    public long DictId { get; set; }

    public byte DictNo { get; set; }

    public string? DictColumn { get; set; }

    public string? DictExplain { get; set; }
}
