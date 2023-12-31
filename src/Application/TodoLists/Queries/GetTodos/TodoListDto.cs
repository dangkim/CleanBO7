﻿using CleanBO7.Application.Common.Mappings;
using CleanBO7.Domain.Entities;

namespace CleanBO7.Application.TodoLists.Queries.GetTodos;

public class TodoListDto : IMapFrom<Product>
{
    public TodoListDto()
    {
        Items = Array.Empty<ProductDto>();
    }

    public int Id { get; init; }

    public string? Title { get; init; }

    public string? Colour { get; init; }

    public IReadOnlyCollection<ProductDto> Items { get; init; }
}
