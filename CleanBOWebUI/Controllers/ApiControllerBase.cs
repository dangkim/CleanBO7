using CleanBO7.CleanBOWebUI.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanBO7.CleanBOWebUI.Controllers;

[ApiController]
[ApiExceptionFilter]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    private ISender? _mediator;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
