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
    public void GivenFileSystemWithOneFile_ReturnsFileSize()
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

    [Fact]
    public void GivenFileSystemWithOneSubDirectoryAndOneFileInThatSubdirectory_ReturnsFileSize()
    {

        // Arrange
        const int fileSize = 203;
        var input = $"""
                     $ cd /
                     $ ls
                     dir testDirectory
                     {fileSize} test.file
                     """;
        var sut = new Day07Solution(input);

        // Act
        var actual = sut.GetSize();

        // Assert
        actual.Should().Be(fileSize);
    }


    [Fact]
    public void GivenComplexFileSystem_ReturnsCorrectValue()
    {

        // Arrange
        var input = """
                    $ cd /
                    $ ls
                    dir a
                    14848514 b.txt
                    8504156 c.dat
                    dir d
                    $ cd a
                    $ ls
                    dir e
                    29116 f
                    2557 g
                    62596 h.lst
                    $ cd e
                    $ ls
                    584 i
                    $ cd ..
                    $ cd ..
                    $ cd d
                    $ ls
                    4060174 j
                    8033020 d.log
                    5626152 d.ext
                    7214296 k
                    """;
        var sut = new Day07Solution(input);

        // Act
        var actual = sut.GetSize();

        // Assert
        actual.Should().Be(48381165);
    }
}
