using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBO7.Application.Configs;
public class JwtInformation
{
    public string Issuer { get; set; }

    public string Key { get; set; }

    public double Duration { get; set; }
}
