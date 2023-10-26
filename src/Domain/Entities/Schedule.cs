using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class Schedule
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public int Interval { get; set; }

    public string Url { get; set; } = null!;

    public bool? Active { get; set; }
}
