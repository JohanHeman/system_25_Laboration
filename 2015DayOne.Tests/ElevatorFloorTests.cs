namespace _2015DayOne.Tests;

public class ElevatorFloorTests
{

    [Theory]
    [InlineData("(())", 0)]
    [InlineData("()()", 0)]
    [InlineData("))(((((", 3)]
    [InlineData("())", -1)]
    public void FloorTracker_ReturnsCorrectFloor(string path, int expected)
    {
       

        // Act
        var actual = FloorTracker.TrackFloor(path);

        // Assert 
        
        Assert.Equal(actual, expected);
    }
    
    
    
}