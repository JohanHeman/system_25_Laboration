namespace _2015DayOne.Tests;

public class ElevatorFloorTests
{

    private readonly FloorTracker _sut = new FloorTracker();
    
    
    
    [Theory]
    [InlineData("(())", 0)]
    [InlineData("()()", 0)]
    [InlineData("))(((((", 3)]
    [InlineData("())", -1)]
    public void FloorTracker_ReturnsCorrectFloor(string path, int expected)
    {

        // Act
        var actual = _sut.TrackFloor(path);

        // Assert 
        
        Assert.Equal(actual, expected);
    }
    
    [Theory]
    [InlineData("j hu HH")]
    [InlineData("((g((UJ ))")]
    
    public void FloorTracker_ThrowsWhenCharIsWrong(string path)
    {
        // Assert
        var actual = Assert.Throws<Exception>(() => _sut.TrackFloor(path));
        
        Assert.Equal(actual.Message, "The symbol must be '(' or ')'");
        // Act
        
    }

    [Fact]
    public void FloorTracker_ThrowsWhenStringIsEmpty()
    {
        // Arrange

        string emptyString = "";
        

        // Act
        Assert.Throws<Exception>(() => _sut.TrackFloor(emptyString));

        // Assert
    }
    
    
    
    
}