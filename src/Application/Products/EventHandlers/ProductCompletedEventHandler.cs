using CleanBO7.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanBO7.Application.ProductEventHandlers;

public class ProductCompletedEventHandler : INotificationHandler<ProductCompletedEvent>
{
    private readonly ILogger<ProductCompletedEventHandler> _logger;

    public ProductCompletedEventHandler(ILogger<ProductCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(ProductCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CleanBO7 Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
