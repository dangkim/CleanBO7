using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class VDraw
{
    public long DrawId { get; set; }

    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int AreaId { get; set; }

    public string AreaName { get; set; } = null!;

    public string DrawNo { get; set; } = null!;

    public int TimeZone { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public DateTime CreateTime { get; set; }

    public int? CancelBetTime { get; set; }

    public string? ResultNo { get; set; }

    public byte? Status { get; set; }

    public byte? StatusCredit { get; set; }

    public DateTime? ResultTime { get; set; }

    public DateTime? ResultTimeCredit { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateTime? UpdateTimeCredit { get; set; }

    public bool? IsManual { get; set; }

    public int? IsManualBy { get; set; }

    public DateTime? IsManualTime { get; set; }

    public int? IsConfirmBy { get; set; }

    public int? IsConfirmByCredit { get; set; }

    public DateTime? IsConfirmTime { get; set; }

    public DateTime? IsConfirmTimeCredit { get; set; }

    public int? IsPayoutBy { get; set; }

    public int? IsPayoutByCredit { get; set; }

    public DateTime? IsPayoutTime { get; set; }

    public DateTime? IsPayoutTimeCredit { get; set; }

    public bool? IsUnprocess { get; set; }

    public bool? IsUnprocessCredit { get; set; }

    public int? IsUnprocessBy { get; set; }

    public int? IsUnprocessByCredit { get; set; }

    public DateTime? IsUnprocessTime { get; set; }

    public DateTime? IsUnprocessTimeCredit { get; set; }

    public string? Remark { get; set; }

    public string? RemarkCredit { get; set; }

    public string? DeviceId { get; set; }

    public string? LiveBet { get; set; }

    public string? MoreBet { get; set; }

    public byte AreaStatus { get; set; }
}
