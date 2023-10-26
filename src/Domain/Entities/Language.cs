using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class Language
{
    public byte LangId { get; set; }

    public string Name { get; set; } = null!;
}
