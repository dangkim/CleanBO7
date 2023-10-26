﻿using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class ProductTicketRestriction
{
    public int TicketId { get; set; }

    public int TicketProductId { get; set; }

    public int TicketVendorId { get; set; }

    public long RestrictionTicketNo { get; set; }
}
