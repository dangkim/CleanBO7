using CleanBO7.Application.Common.Exceptions;
using CleanBO7.Application.Common.Interfaces;
using CleanBO7.Domain.Entities;
using CleanBO7.Domain.Enums;
using MediatR;

namespace CleanBO7.Application.Products.Commands.UpdateProductDetail;

public record UpdateProductDetailCommand : IRequest
{
    public int Id { get; init; }

    public int ListId { get; init; }

    public PriorityLevel Priority { get; init; }

    public string? Note { get; init; }
}

public class UpdateProductDetailCommandHandler : IRequestHandler<UpdateProductDetailCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateProductDetailCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateProductDetailCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Products
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Product), request.Id);
        }

        //entity.ListId = request.ListId;
        //entity.Priority = request.Priority;
        //entity.Note = request.Note;

        await _context.SaveChangesAsync(cancellationToken);
    }
}
