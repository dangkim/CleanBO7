﻿using CleanBO7.Application.Common.Mappings;
using CleanBO7.Domain.Entities;

namespace CleanBO7.Application.Products.Queries.GetProductsWithPagination;

public class ProductBriefDto : IMapFrom<Product>
{
    public int ProductId { get; init; }

    public int ListId { get; init; }

    public string? ProductName { get; init; }

    public bool Done { get; init; }
}
