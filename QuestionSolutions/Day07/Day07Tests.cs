namespace QuestionSolutions.Day07;

public class Day07Tests
{
    [Fact]
    public void GivenEmptyFileSystem_Returns0()
    {
        // Arrange
        var input = """
                    $ cd /
                    """;
        var sut = new Day07Solution(input);

        // Act
        var actual = sut.GetSize();

        // Assert
        actual.Should().Be(0);
    }

    [Fact]
    public void GivenFileSystemWithOneFile_ReturnsFIleSize()
    {

        // Arrange
        const int fileSize = 203;
        var input = $"""
                     $ cd /
                     $ ls
                     {fileSize} test.file
                     """;
        var sut = new Day07Solution(input);

        // Act
        var actual = sut.GetSize();

        // Assert
        actual.Should().Be(fileSize);
    }
}
