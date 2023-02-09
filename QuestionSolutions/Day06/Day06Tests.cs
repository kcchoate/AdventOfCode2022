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
}
