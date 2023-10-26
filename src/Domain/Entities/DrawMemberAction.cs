using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class DrawMemberAction
{
    public long Id { get; set; }

    public long DrawId { get; set; }

    public long MemberUid { get; set; }

    public short ActionId { get; set; }

    public string Content { get; set; } = null!;

    public string Steps { get; set; } = null!;

    public byte[] RowVersion { get; set; } = null!;

    public DateTime CreatedTime { get; set; }
}
