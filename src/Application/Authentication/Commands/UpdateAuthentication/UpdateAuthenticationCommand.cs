using CleanBO7.Application.Common.Exceptions;
using CleanBO7.Application.Common.Interfaces;
using CleanBO7.Domain.Entities;
using MediatR;

namespace CleanBO7.Application.Authentication.Commands.UpdateAuthentication;

public record UpdateAuthenticationCommand : IRequest
{
    public int Id { get; init; }

    public string? Title { get; init; }

    public bool Done { get; init; }
}

public class UpdateProductCommandHandler : IRequestHandler<UpdateAuthenticationCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateProductCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(UpdateAuthenticationCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Products
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Product), request.Id);
        }

        entity.ProductName = request.Title;
        entity.Active = request.Done;

        await _context.SaveChangesAsync(cancellationToken);
    }
}
