namespace QuestionSolutions.Day06;

public class Day06Tests
{
    private readonly Day06Solution _sut = new();

    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 7)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
    public void FindStartOfPacketMarker_GivenBasicInput_ReturnsCorrectMarker(string input, int expected)
    {
        // Act
        var result = _sut.FindStartOfPacketMarker(input);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public async Task PartOneSolution()
    {
        // Arrange
        var fileContent = await File.ReadAllTextAsync(Path.Combine("Day06", "input.txt"));

        // Act
        var result = _sut.FindStartOfPacketMarker(fileContent);

        // Assert
        result.Should().Be(1965);
    }

    [Theory]
    [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)]
    [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 23)]
    [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 23)]
    [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)]
    [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)]
    public void FindStartOfMessageMarker_GivenBasicInput_ReturnsCorrectMarker(string input, int expected)
    {
        // Act
        var result = _sut.FindStartOfMessageMarker(input);

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public async Task PartTwoSolution()
    {
        // Arrange
        var fileContent = await File.ReadAllTextAsync(Path.Combine("Day06", "input.txt"));

        // Act
        var result = _sut.FindStartOfMessageMarker(fileContent);

        // Assert
        result.Should().Be(2773);
    }

}
