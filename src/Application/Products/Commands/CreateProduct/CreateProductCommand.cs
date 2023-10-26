using CleanBO7.Application.Common.Interfaces;
using CleanBO7.Domain.Entities;
using CleanBO7.Domain.Events;
using MediatR;

namespace CleanBO7.Application.Products.Commands.CreateProduct;

public record CreateProductCommand : IRequest<int>
{
    public int ListId { get; init; }

    public string? Title { get; init; }
}

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateProductCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = new Product
        {
            ProductId = request.ListId,
            DisplayName = request.Title,
        };

        entity.AddDomainEvent(new ProductCreatedEvent(entity));

        _context.Products.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.ProductId;
    }
}
