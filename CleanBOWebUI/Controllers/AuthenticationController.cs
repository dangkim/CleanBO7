using CleanBO7.CleanBOWebUI.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CleanBOWebUI.Controllers;

[AllowAnonymous]
public class AuthenticationController : ApiControllerBase
{
    //[HttpGet]
    //[Route("/api/[controller]")]
    //public async Task<Result<string, ErrorCode>> SecurityCheck(string ticket)
    //{
    //    var response = await authenticationServiceClient.DoSecurityCheck(ticket);
    //    if (response?.IsSuccess != true)
    //    {
    //        logger.LogWarning("Security check failed for ticket {Ticket}", ticket);
    //        return ErrorCode.AccessDenied;
    //    }

    //    using var db = databaseManager.GetWritableDatabase();
    //    var @operator = await GetOperator(response.Operator, db);

    //    if (@operator == null)
    //    {
    //        logger.LogWarning("Operator {Operator} not found", response.Operator);
    //        return ErrorCode.AccessDenied;
    //    }

    //    var account = await AuthenticateMember(@operator, response, db);

    //    var jwtUser = new JwtUser(account);
    //    var token = jwtUser.GetToken(
    //        authenticationConfig.Jwt.Key,
    //        authenticationConfig.Jwt.Issuer,
    //        authenticationConfig.Jwt.Issuer,
    //        authenticationConfig.Jwt.Duration);

    //    return token;
    //}
}
