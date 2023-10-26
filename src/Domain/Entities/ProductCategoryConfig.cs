using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class ProductCategoryConfig
{
    public int? CategoryId { get; set; }

    public int? ProductId { get; set; }

    public int? AreaId { get; set; }

    public int Id { get; set; }

    public virtual ProductCategory? Category { get; set; }
}
