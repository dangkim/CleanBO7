using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class Notice
{
    public int NoticeId { get; set; }

    public int? NoticeGroupId { get; set; }

    public string? NoticeProductId { get; set; }

    public string? NoticeVendorId { get; set; }

    public byte? NoticeLangId { get; set; }

    public string? NoticeContent { get; set; }

    public int? NoticeAdminId { get; set; }

    public DateTime? NoticePubTime { get; set; }

    public DateTime? NoticeValidTime { get; set; }

    public DateTime? NoticeUpdateTime { get; set; }
}
