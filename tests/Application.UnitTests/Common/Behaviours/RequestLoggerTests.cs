using CleanBO7.Application.Common.Behaviours;
using CleanBO7.Application.Common.Interfaces;
using CleanBO7.Application.Products.Commands.CreateProduct;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace CleanBO7.Application.UnitTests.Common.Behaviours;

public class RequestLoggerTests
{
    private Mock<ILogger<CreateAuthenticationCommand>> _logger = null!;
    private Mock<ICurrentUserService> _currentUserService = null!;
    private Mock<IIdentityService> _identityService = null!;

    [SetUp]
    public void Setup()
    {
        _logger = new Mock<ILogger<CreateAuthenticationCommand>>();
        _currentUserService = new Mock<ICurrentUserService>();
        _identityService = new Mock<IIdentityService>();
    }

    [Test]
    public async Task ShouldCallGetUserNameAsyncOnceIfAuthenticated()
    {
        _currentUserService.Setup(x => x.UserId).Returns(Guid.NewGuid().ToString());

        var requestLogger = new LoggingBehaviour<CreateAuthenticationCommand>(_logger.Object, _currentUserService.Object);

        await requestLogger.Process(new CreateAuthenticationCommand { ListId = 1, Title = "title" }, new CancellationToken());

        _identityService.Verify(i => i.GetUserNameAsync(It.IsAny<string>()), Times.Once);
    }

    [Test]
    public async Task ShouldNotCallGetUserNameAsyncOnceIfUnauthenticated()
    {
        var requestLogger = new LoggingBehaviour<CreateAuthenticationCommand>(_logger.Object, _currentUserService.Object);

        await requestLogger.Process(new CreateAuthenticationCommand { ListId = 1, Title = "title" }, new CancellationToken());

        _identityService.Verify(i => i.GetUserNameAsync(It.IsAny<string>()), Times.Never);
    }
}
