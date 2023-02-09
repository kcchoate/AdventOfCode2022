namespace QuestionSolutions.Extensions;

public class RangeExtensionTests
{
    [Fact]
    public void Contains_WhenNumberIsInsideRange_ReturnsTrue()
    {
        // Arrange
        const int input = 2;
        var range = 1..3;
        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Contains_WhenNumberIsEqualToRangeStart_ReturnsTrue()
    {
        // Arrange
        const int input = 1;
        var range = 1..3;
        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Contains_WhenNumberIsEqualToRangeEnd_ReturnsTrue()
    {
        // Arrange
        const int input = 3;
        var range = 1..3;
        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Contains_WhenNumberIsLessThanRangeStart_ReturnsFalse()
    {
        // Arrange
        const int input = 0;
        var range = 1..3;
        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void Contains_WhenNumberIsGreaterThanRangeEnd_ReturnsFalse()
    {
        // Arrange
        const int input = 4;
        var range = 1..3;
        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeFalse();
    }
}
