using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class VendorCurrency
{
    public int Id { get; set; }

    public int VendorId { get; set; }

    public byte CurrencyId { get; set; }
}
