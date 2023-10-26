using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class CustomWalletRound
{
    public int Id { get; set; }

    public long BetId { get; set; }

    public int ProductId { get; set; }

    public long RoundId { get; set; }
}
