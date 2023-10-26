using System.Runtime.Serialization;
using AutoMapper;
using CleanBO7.Application.Common.Mappings;
using CleanBO7.Application.Common.Models;
using CleanBO7.Application.TodoLists.Queries.GetTodos;
using CleanBO7.Domain.Entities;
using NUnit.Framework;

namespace CleanBO7.Application.UnitTests.Common.Mappings;

public class MappingTests
{
    private readonly IConfigurationProvider _configuration;
    private readonly IMapper _mapper;

    public MappingTests()
    {
        _configuration = new MapperConfiguration(config => 
            config.AddProfile<MappingProfile>());

        _mapper = _configuration.CreateMapper();
    }

    [Test]
    public void ShouldHaveValidConfiguration()
    {
        _configuration.AssertConfigurationIsValid();
    }

    [Test]
    //[TestCase(typeof(TodoList), typeof(TodoListDto))]
    [TestCase(typeof(Product), typeof(ProductDto))]
    //[TestCase(typeof(TodoList), typeof(LookupDto))]
    //[TestCase(typeof(Product), typeof(LookupDto))]
    public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        var instance = GetInstanceOf(source);

        _mapper.Map(instance, source, destination);
    }

    private object GetInstanceOf(Type type)
    {
        if (type.GetConstructor(Type.EmptyTypes) != null)
            return Activator.CreateInstance(type)!;

        // Type without parameterless constructor
        return FormatterServices.GetUninitializedObject(type);
    }
}
