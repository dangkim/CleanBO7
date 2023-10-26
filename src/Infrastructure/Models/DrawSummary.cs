using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class DrawSummary
{
    public long? DrawId { get; set; }

    public string? DrawNo { get; set; }

    public DateTime? DateConsolidated { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? ProductId { get; set; }

    public int? AreaId { get; set; }

    public long Id { get; set; }
}
