using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class WalletProduct
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string MerchantId { get; set; } = null!;

    public string MerchantPassword { get; set; } = null!;

    public string GameId { get; set; } = null!;
}
