﻿using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class TradingPayoutPk10
{
    public long TradingId { get; set; }

    public long TradingMemberUid { get; set; }

    public int TradingVendorId { get; set; }

    public byte TradingType { get; set; }

    public long TradingBetId { get; set; }

    public string TradingReferenceNo { get; set; } = null!;

    public decimal TradingMoney { get; set; }

    public byte TradingCurrencyId { get; set; }

    public decimal TradingCurrencyRate { get; set; }

    public byte TradingStatus { get; set; }

    public DateTime TradingTime { get; set; }

    public decimal? TradingWalletStart { get; set; }

    public decimal? TradingWalletEnd { get; set; }

    public DateTime? TradingUpdateTime { get; set; }

    public string? TradingTrxId { get; set; }

    public DateTime? TradingArchiveDate { get; set; }
}
