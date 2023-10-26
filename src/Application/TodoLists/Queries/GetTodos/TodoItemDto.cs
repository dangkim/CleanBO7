using AutoMapper;
using CleanBO7.Application.Common.Mappings;
using CleanBO7.Domain.Entities;

namespace CleanBO7.Application.TodoLists.Queries.GetTodos;

public class ProductDto : IMapFrom<Product>
{
    public int Id { get; init; }

    public int ListId { get; init; }

    public string? Title { get; init; }

    public bool Done { get; init; }

    public int Priority { get; init; }

    public string? Note { get; init; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Product, ProductDto>()
            .ForMember(d => d.Priority, opt => opt.MapFrom(s => (int)s.ProductId));
    }
}
