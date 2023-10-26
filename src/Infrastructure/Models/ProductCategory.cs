using System;
using System.Collections.Generic;

namespace CleanBO7.Infrastructure.Models;

public partial class ProductCategory
{
    public int CategoryId { get; set; }

    public string? Name { get; set; }

    public string? Tag { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ProductCategoryConfig> ProductCategoryConfigs { get; set; } = new List<ProductCategoryConfig>();
}
