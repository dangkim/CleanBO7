using CleanBO7.Application.TodoLists.Queries.GetTodos;
using CleanBO7.Domain.Entities;
using CleanBO7.Domain.ValueObjects;
using FluentAssertions;
using NUnit.Framework;

namespace CleanBO7.Application.IntegrationTests.TodoLists.Queries;

using static Testing;

public class GetTodosTests : BaseTestFixture
{
    [Test]
    public async Task ShouldReturnPriorityLevels()
    {
        await RunAsDefaultUserAsync();

        var query = new GetTodosQuery();

        var result = await SendAsync(query);

        result.PriorityLevels.Should().NotBeEmpty();
    }

    [Test]
    public async Task ShouldReturnAllListsAndItems()
    {
        await RunAsDefaultUserAsync();

        //await AddAsync(new TodoList
        //{
        //    Title = "Shopping",
        //    Colour = Colour.Blue,
        //    Items =
        //            {
        //                new Product { Title = "Apples", Done = true },
        //                new Product { Title = "Milk", Done = true },
        //                new Product { Title = "Bread", Done = true },
        //                new Product { Title = "Toilet paper" },
        //                new Product { Title = "Pasta" },
        //                new Product { Title = "Tissues" },
        //                new Product { Title = "Tuna" }
        //            }
        //});

        var query = new GetTodosQuery();

        var result = await SendAsync(query);

        result.Lists.Should().HaveCount(1);
        result.Lists.First().Items.Should().HaveCount(7);
    }

    [Test]
    public async Task ShouldDenyAnonymousUser()
    {
        var query = new GetTodosQuery();

        var action = () => SendAsync(query);
        
        await action.Should().ThrowAsync<UnauthorizedAccessException>();
    }
}
