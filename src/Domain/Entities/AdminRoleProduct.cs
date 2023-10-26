using System;
using System.Collections.Generic;

namespace CleanBO7.Domain.Entities;

public partial class AdminRoleProduct
{
    public int RoleProductId { get; set; }

    public int ProductId { get; set; }

    public int RoleId { get; set; }

    public string? RoleLevel { get; set; }
}
