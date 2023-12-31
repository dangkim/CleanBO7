﻿using CleanBO7.Application.Common.Exceptions;
using CleanBO7.Application.Common.Interfaces;
using CleanBO7.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanBO7.Application.TodoLists.Commands.DeleteTodoList;

public record DeleteTodoListCommand(int Id) : IRequest;

public class DeleteTodoListCommandHandler : IRequestHandler<DeleteTodoListCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteTodoListCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteTodoListCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Products
            .Where(l => l.ProductId == request.Id)
            .SingleOrDefaultAsync(cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Product), request.Id);
        }

        _context.Products.Remove(entity);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
