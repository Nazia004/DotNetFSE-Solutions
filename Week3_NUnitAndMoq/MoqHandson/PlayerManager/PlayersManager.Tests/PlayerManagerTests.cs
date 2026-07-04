using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayersManager.Tests;

public class PlayerManagerTests
{
    [Test]
    public void RegisterNewPlayer_ShouldReturnTrue_WhenPlayerAdded()
    {
        // Arrange
        var player = new Player
        {
            Id = 1,
            Name = "Virat",
            Age = 35
        };

        var mapperMock = new Mock<IPlayerMapper>();

        mapperMock
            .Setup(x => x.AddPlayer(player))
            .Returns(true);

        var manager = new PlayerManager(mapperMock.Object);

        // Act
        bool result = manager.RegisterNewPlayer(player);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void RegisterNewPlayer_ShouldReturnFalse_WhenPlayerNotAdded()
    {
        // Arrange
        var player = new Player
        {
            Id = 2,
            Name = "Rohit",
            Age = 37
        };

        var mapperMock = new Mock<IPlayerMapper>();

        mapperMock
            .Setup(x => x.AddPlayer(player))
            .Returns(false);

        var manager = new PlayerManager(mapperMock.Object);

        // Act
        bool result = manager.RegisterNewPlayer(player);

        // Assert
        Assert.That(result, Is.False);
    }
}