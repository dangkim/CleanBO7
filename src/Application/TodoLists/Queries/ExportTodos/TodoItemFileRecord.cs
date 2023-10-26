using CleanBO7.Application.Common.Mappings;
using CleanBO7.Domain.Entities;

namespace CleanBO7.Application.TodoLists.Queries.ExportTodos;

public class ProductRecord : IMapFrom<Product>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
