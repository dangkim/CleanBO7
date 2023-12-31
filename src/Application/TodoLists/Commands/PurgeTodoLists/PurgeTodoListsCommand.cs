﻿using CleanBO7.Application.Common.Interfaces;
using CleanBO7.Application.Common.Security;
using MediatR;

namespace CleanBO7.Application.TodoLists.Commands.PurgeTodoLists;

[Authorize(Roles = "Administrator")]
[Authorize(Policy = "CanPurge")]
public record PurgeTodoListsCommand : IRequest;

public class PurgeTodoListsCommandHandler : IRequestHandler<PurgeTodoListsCommand>
{
    private readonly IApplicationDbContext _context;

    public PurgeTodoListsCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(PurgeTodoListsCommand request, CancellationToken cancellationToken)
    {
        _context.Products.RemoveRange(_context.Products);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
