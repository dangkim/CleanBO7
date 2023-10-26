using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class SessionLess
{
    public long SessionLessAutoId { get; set; }

    /// <summary>
    /// Session Key it&apos;s to pair the Captcha
    /// </summary>
    public string SessionLessKey { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime DateTime { get; set; }
}
