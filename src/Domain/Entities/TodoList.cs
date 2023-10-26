﻿namespace CleanBO7.Domain.Entities;

public class TodoList : BaseAuditableEntity
{
    public string? Title { get; set; }

    public Colour Colour { get; set; } = Colour.White;

    public IList<Product> Items { get; private set; } = new List<Product>();
}
