namespace QuestionSolutions.Day08;

public class Day08Tests
{
    [Fact]
    public void GivenGridOfAllVisibleTrees_ReturnsTotalNumberOfTrees()
    {
        // Arrange
        const string input = """
                             134
                             786
                             254
                             """;

        var sut = new Day08Solution(input);

        // Act
        var actual = sut.CountVisibleTrees();

        // Assert
        actual.Should().Be(9);
    }

    [Fact]
    public void GivenComplexInput_ReturnsTotalNumberOfTrees()
    {
        // Arrange
        const string input = """
                             30373
                             25512
                             65332
                             33549
                             35390
                             """;

        var sut = new Day08Solution(input);

        // Act
        var actual = sut.CountVisibleTrees();

        // Assert
        actual.Should().Be(21);
    }

    [Fact]
    public async Task Problem01()
    {
        // Arrange
        var fileContent = await File.ReadAllTextAsync(Path.Combine("Day08", "input.txt"));

        // Act
        var sut = new Day08Solution(fileContent);
        var actual = sut.CountVisibleTrees();

        // Assert
        actual.Should().Be(1851);
    }
}
