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

    [Fact]
    public void Contains_WhenInputRangeIsWithinRange_ReturnsTrue()
    {
        // Arrange
        var input = 2..3;
        var range = 1..4;

        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Contains_WhenInputRangeStartEqualsRangeStart_AndEndsBeforeRangeEnd_ReturnsTrue()
    {
        // Arrange
        var input = 1..3;
        var range = 1..4;

        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Contains_WhenInputRangeStartsAfterRangeStart_AndEndsOnRangeEnd_ReturnsTrue()
    {
        // Arrange
        var input = 2..4;
        var range = 1..4;

        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Contains_WhenInputRangeIsSameAsRange_ReturnsTrue()
    {
        // Arrange
        var input = 1..4;
        var range = 1..4;

        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Contains_WhenInputRangeStartsBeforeRange_ReturnsTrue()
    {
        // Arrange
        var input = 0..3;
        var range = 1..4;

        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void Contains_WhenInputRangeEndsAfterRange_ReturnsTrue()
    {
        // Arrange
        var input = 2..5;
        var range = 1..4;

        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void Contains_WhenInputRangeStartsBeforeRange_AndEndsAfterRange_ReturnsTrue()
    {
        // Arrange
        var input = 0..5;
        var range = 1..4;

        // Act
        var result = range.Contains(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void Overlaps_WhenInputRangeStartsBeforeRange_AndInputEndEqualsRangeStart_ReturnsTrue()
    {
        // Arrange
        var input = 1..2;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Overlaps_WhenInputRangeStartsBeforeRange_AndInputEndIsWithinRange_ReturnsTrue()
    {
        // Arrange
        var input = 1..3;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Overlaps_WhenInputStartEqualsRangStart_AndInputEndIsWithinRange_ReturnsTrue()
    {
        // Arrange
        var input = 2..3;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Overlaps_WhenInputRangeEqualsRange_ReturnsTrue()
    {
        // Arrange
        var input = 2..5;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Overlaps_WhenInputRangeStartsInsideRange_AndInputRangeEndsOnRangeEnd_ReturnsTrue()
    {
        // Arrange
        var input = 3..5;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Overlaps_WhenInputRangeIsEntireWithinRange_ReturnsTrue()
    {
        // Arrange
        var input = 3..4;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Overlaps_WhenInputRangeStartsWithinRange_AndEndsOutsideOfRange_ReturnsTrue()
    {
        // Arrange
        var input = 3..6;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Overlaps_WhenInputRangeStartsAtEndOfRange_ReturnsTrue()
    {
        // Arrange
        var input = 5..6;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void Overlaps_WhenInputRangeIsEntireBeforeRange_ReturnsFalse()
    {
        // Arrange
        var input = 0..1;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void Overlaps_WhenInputRangeIsEntireAfterRange_ReturnsFalse()
    {
        // Arrange
        var input = 6..7;
        var range = 2..5;

        // Act
        var result = range.Overlaps(input);

        // Assert
        result.Should().BeFalse();
    }
}
