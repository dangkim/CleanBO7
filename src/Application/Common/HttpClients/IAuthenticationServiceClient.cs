using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanBO7.Application.Common.Models;

namespace CleanBO7.Application.Common.HttpClients;
public interface IAuthenticationServiceClient
{
    /// <summary>
    /// Perform security check on CAS.
    /// </summary>
    /// <param name="ticket">Authentication ticket from CAS.</param>
    /// <returns>Security check response in JSON string format.</returns>
    Task<CasSecurityCheckResponse> DoSecurityCheck(string ticket);
}
