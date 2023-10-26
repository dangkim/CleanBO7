using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanBO7.Application.Common.Interfaces;
using CleanBO7.Application.Common.Mappings;
using CleanBO7.Application.Common.Models;
using MediatR;

namespace CleanBO7.Application.Authentication.Queries.GetProductsWithPagination;

public record GetAuthenticationWithPaginationQuery : IRequest<PaginatedList<AuthenticationBriefDto>>
{
    public int ListId { get; init; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetProductsWithPaginationQueryHandler : IRequestHandler<GetAuthenticationWithPaginationQuery, PaginatedList<AuthenticationBriefDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetProductsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<AuthenticationBriefDto>> Handle(GetAuthenticationWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await _context.Products
            .Where(x => x.ProductId == request.ListId)
            .OrderBy(x => x.ProductName)
            .ProjectTo<AuthenticationBriefDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
