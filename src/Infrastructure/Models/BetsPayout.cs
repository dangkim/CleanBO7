using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class BetsPayout
{
    public long BetId { get; set; }

    public long BetNo { get; set; }

    public long MemberUid { get; set; }

    public byte MemberType { get; set; }

    public byte Currency { get; set; }

    public decimal Rate { get; set; }

    public long? DrawId { get; set; }

    public byte BetTypeUid { get; set; }

    public decimal Stake { get; set; }

    public decimal Amount { get; set; }

    public int? Bets { get; set; }

    public decimal? AmountWinLose { get; set; }

    public string? Odds { get; set; }

    public string? BetContent { get; set; }

    public byte BetStatus { get; set; }

    public byte BetUpdateStatus { get; set; }

    public byte IsWin { get; set; }

    public DateTime TimeBet { get; set; }

    public DateTime ActionTime { get; set; }

    public string? Remarks { get; set; }

    public byte? PlatformOs { get; set; }

    public string? ClientIp { get; set; }

    public DateTime? ArchiveDate { get; set; }

    public string? ReferenceNo { get; set; }

    public Guid? ReportRefNo { get; set; }

    public DateTime? ActualBetTime { get; set; }

    public int? BetWinCount { get; set; }

    public long? BetBundleId { get; set; }
}
