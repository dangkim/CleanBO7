using CleanBO7.Application.Common.Exceptions;
using CleanBO7.Application.Products.Commands.CreateProduct;
using CleanBO7.Application.Products.Commands.UpdateProduct;
using CleanBO7.Application.TodoLists.Commands.CreateTodoList;
using CleanBO7.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace CleanBO7.Application.IntegrationTests.Products.Commands;

using static Testing;

public class UpdateProductTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidProductId()
    {
        var command = new UpdateProductCommand { Id = 99, Title = "New Title" };
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldUpdateProduct()
    {
        var userId = await RunAsDefaultUserAsync();

        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateProductCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        var command = new UpdateProductCommand
        {
            Id = itemId,
            Title = "Updated Item Title"
        };

        await SendAsync(command);

        var item = await FindAsync<Product>(itemId);

        item.Should().NotBeNull();
        //item!.Title.Should().Be(command.Title);
        //item.LastModifiedBy.Should().NotBeNull();
        //item.LastModifiedBy.Should().Be(userId);
        //item.LastModified.Should().NotBeNull();
        //item.LastModified.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    }
}
