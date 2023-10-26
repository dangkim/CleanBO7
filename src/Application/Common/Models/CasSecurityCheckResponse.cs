using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CleanBO7.Application.Common.Models;
public class CasSecurityCheckResponse
{
    public string? User { get; set; }

    [JsonProperty("Op")]
    public string? Operator { get; set; }

    public string Code { get; set; }

    public bool IsSuccess => Code.Contains("200");

    public string? Message { get; private set; }

    public static CasSecurityCheckResponse Deserialize(string securityCheckResponseString)
    {
        var securityCheck = JsonConvert.DeserializeObject<CasSecurityCheckResponse>(securityCheckResponseString);

        if (securityCheck != null)
        {
            securityCheck.Message = securityCheckResponseString;
        }

        return securityCheck;
    }
}
