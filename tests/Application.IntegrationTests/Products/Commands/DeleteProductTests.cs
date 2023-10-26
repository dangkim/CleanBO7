using CleanBO7.Application.Common.Exceptions;
using CleanBO7.Application.Products.Commands.CreateProduct;
using CleanBO7.Application.Products.Commands.DeleteProduct;
using CleanBO7.Application.TodoLists.Commands.CreateTodoList;
using CleanBO7.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace CleanBO7.Application.IntegrationTests.Products.Commands;

using static Testing;

public class DeleteProductTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidProductId()
    {
        var command = new DeleteProductCommand(99);

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteProduct()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateProductCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        await SendAsync(new DeleteProductCommand(itemId));

        var item = await FindAsync<Product>(itemId);

        item.Should().BeNull();
    }
}
