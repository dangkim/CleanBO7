using CleanBO7.Application.Common.Exceptions;
using CleanBO7.Application.Products.Commands.CreateProduct;
using CleanBO7.Application.TodoLists.Commands.CreateTodoList;
using CleanBO7.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace CleanBO7.Application.IntegrationTests.Products.Commands;

using static Testing;

public class CreateProductTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireMinimumFields()
    {
        var command = new CreateProductCommand();

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<ValidationException>();
    }

    [Test]
    public async Task ShouldCreateProduct()
    {
        var userId = await RunAsDefaultUserAsync();

        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var command = new CreateProductCommand
        {
            ListId = listId,
            Title = "Tasks"
        };

        var itemId = await SendAsync(command);

        var item = await FindAsync<Product>(itemId);

        item.Should().NotBeNull();
        //item!.ListId.Should().Be(command.ListId);
        //item.Title.Should().Be(command.Title);
        //item.CreatedBy.Should().Be(userId);
        //item.Created.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
        //item.LastModifiedBy.Should().Be(userId);
        //item.LastModified.Should().BeCloseTo(DateTime.Now, TimeSpan.FromMilliseconds(10000));
    }
}
