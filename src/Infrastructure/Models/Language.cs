using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class Language
{
    public byte LangId { get; set; }

    public string Name { get; set; } = null!;
}
