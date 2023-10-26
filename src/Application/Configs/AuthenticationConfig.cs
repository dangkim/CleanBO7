using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBO7.Application.Configs;
public class AppSettingsConfig
{
    public JwtInformation Jwt { get; set; }

    public string CasClientId { get; set; }

    public string CasClientPassword { get; set; }

    public string CasSecurityCheckUrl { get; set; }
}
