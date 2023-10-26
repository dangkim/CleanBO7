using CleanBO7.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CleanBO7.Application.Common.Interfaces;

public interface LottoDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<Product> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    public IQueryable<TResult> SqlQueryRaw<TResult>([NotParameterized] string sql, params object[] parameters);

}
