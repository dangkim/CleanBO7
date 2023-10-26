using CleanBO7.Application.Common.Models;
using CleanBO7.Application.Products.Commands.CreateProduct;
using CleanBO7.Application.Products.Commands.DeleteProduct;
using CleanBO7.Application.Products.Commands.UpdateProduct;
using CleanBO7.Application.Products.Commands.UpdateProductDetail;
using CleanBO7.Application.Products.Queries.GetProductsWithPagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CleanBO7.CleanBOWebUI.Controllers;

[Authorize]
public class ProductsController : ApiControllerBase
{    
    [HttpGet]
    public async Task<ActionResult<PaginatedList<ProductBriefDto>>> GetProductsWithPagination([FromQuery] GetProductsWithPaginationQuery query)
    {
        return await Mediator.Send(query);
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateProductCommand command)
    {
        return await Mediator.Send(command);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> Update(int id, UpdateProductCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        await Mediator.Send(command);

        return NoContent();
    }

    [HttpPut("[action]")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> UpdateItemDetails(int id, UpdateProductDetailCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        await Mediator.Send(command);

        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> Delete(int id)
    {
        await Mediator.Send(new DeleteProductCommand(id));

        return NoContent();
    }
}
