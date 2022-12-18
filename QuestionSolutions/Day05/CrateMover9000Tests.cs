namespace QuestionSolutions.Day05;

public class CrateMover9000Tests
{
    [Fact]
    public async Task Question1()
    {
        var fileLines = await File.ReadAllLinesAsync(Path.Combine("Day05", "input.txt"));

        var sut = new Day05Solution(fileLines);
        var result = sut.PerformWorkWithCrateMover9000();

        result.Should().Be("JCMHLVGMG");
    }

    [Fact]
    public void GivenTwoStacks_AndACrateIsMovedFromOneToTheOther_CorrectResultIsReturned()
    {
        const string fileContent = """
                [G]
            [C] [D]
             1   2

            move 1 from 2 to 1
            """;

        var fileLines = fileContent.Split(Environment.NewLine);

        var sut = new Day05Solution(fileLines);

        var result = sut.PerformWorkWithCrateMover9000();

        result.Should().Be("GD");
    }
    
    [Fact]
    public void GivenThreeStacks_AndAllCratesAreMovedOutOfOne_CorrectResultIsReturned()
    {
        const string fileContent = """
                [G] [B]
            [C] [D] [Z]
             1   2   3

            move 1 from 2 to 1
            move 1 from 2 to 3
            """;

        var fileLines = fileContent.Split(Environment.NewLine);

        var sut = new Day05Solution(fileLines);

        var result = sut.PerformWorkWithCrateMover9000();

        result.Should().Be("G D");
    }

    [Fact]
    public void GivenThreeStacks_AndAllCratesAreMovedOutOfOneInOneInstruction_CorrectResultIsReturned()
    {
        const string fileContent = """
                [G] [B]
            [C] [D] [Z]
             1   2   3

            move 2 from 2 to 1
            """;

        var fileLines = fileContent.Split(Environment.NewLine);

        var sut = new Day05Solution(fileLines);

        var result = sut.PerformWorkWithCrateMover9000();

        result.Should().Be("D B");
    }

    [Fact]
    public void GivenExampleInput1_CorrectResultIsReturned()
    {
        const string fileContent = """
                [D]    
            [N] [C]    
            [Z] [M] [P]
             1   2   3 

            move 1 from 2 to 1
            move 3 from 1 to 3
            move 2 from 2 to 1
            move 1 from 1 to 2
            """;

        var fileLines = fileContent.Split(Environment.NewLine);

        var sut = new Day05Solution(fileLines);

        var result = sut.PerformWorkWithCrateMover9000();

        result.Should().Be("CMZ");
    }
}