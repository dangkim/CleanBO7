using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CleanBO7.Application.Common.Models;
using CleanBO7.Application.Configs;
using Microsoft.Extensions.Options;

namespace CleanBO7.Application.Common.HttpClients;
/// <summary>
/// HttpClient for CAS.
/// </summary>
public class CasClient : IAuthenticationServiceClient
{
    private readonly HttpClient client;
    private readonly AppSettingsConfig authenticationConfig;

    /// <summary>
    /// Creates an instance of the client.
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/> instance.</param>
    /// <param name="authenticationConfig"><see cref="AppSettingsConfig"/> options instance.</param>
    public CasClient(HttpClient client, IOptions<AppSettingsConfig> authenticationConfig)
    {
        this.client = client;
        this.authenticationConfig = authenticationConfig.Value;
    }

    /// <summary>
    /// Perform security check on CAS.
    /// </summary>
    /// <param name="ticket">Authentication ticket from CAS.</param>
    /// <returns>Security check response in JSON string format.</returns>
    public async Task<CasSecurityCheckResponse> DoSecurityCheck(string ticket)
    {
        var checkSum = HashUtil.SHA1Hash($"{authenticationConfig.CasClientId}{ticket}{authenticationConfig.CasClientPassword}");
        var url = $"{authenticationConfig.CasSecurityCheckUrl}/{authenticationConfig.CasClientId}/{ticket}/{checkSum}";

        var requestMsg = new HttpRequestMessage(HttpMethod.Post, url);
        requestMsg.Headers.Add(nameof(HttpRequestHeader.ContentType), "application/x-www-form-urlencoded");

        var result = await client.SendAsync(requestMsg);
        var response = await result.Content.ReadAsStringAsync();

        return CasSecurityCheckResponse.Deserialize(response);
    }
}
