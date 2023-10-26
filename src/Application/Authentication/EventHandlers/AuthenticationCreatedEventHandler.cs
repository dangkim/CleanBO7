using CleanBO7.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanBO7.Application.Authentication.EventHandlers;

public class AuthenticationCreatedEventHandler : INotificationHandler<ProductCreatedEvent>
{
    private readonly ILogger<AuthenticationCreatedEventHandler> _logger;

    public AuthenticationCreatedEventHandler(ILogger<AuthenticationCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(ProductCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CleanBO7 Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
