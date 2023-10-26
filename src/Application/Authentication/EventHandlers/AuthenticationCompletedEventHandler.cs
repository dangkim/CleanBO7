using CleanBO7.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanBO7.Application.Authentication.EventHandlers;

public class AuthenticationCompletedEventHandler : INotificationHandler<ProductCompletedEvent>
{
    private readonly ILogger<AuthenticationCompletedEventHandler> _logger;

    public AuthenticationCompletedEventHandler(ILogger<AuthenticationCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(ProductCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CleanBO7 Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
