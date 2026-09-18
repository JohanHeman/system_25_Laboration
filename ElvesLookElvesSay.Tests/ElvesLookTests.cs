namespace ElvesLookElvesSay.Tests;

public class ElvesLookTests
{

    
    [Fact]
    public void CountNumberOcurrance_OneShouldReturnOneOne()
    {
        // Arrange
        var sut = new LookSay();
        var expected = 11;
        // Act
        var actual = sut.CountNumberOcurrance(1);

        // Assert
        Assert.Equal(expected, actual);
    }
}