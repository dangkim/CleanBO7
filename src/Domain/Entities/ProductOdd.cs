﻿using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class ProductOdd
{
    public int Id { get; set; }

    public int Index { get; set; }

    public int ProductId { get; set; }

    public string Odds { get; set; } = null!;
}
