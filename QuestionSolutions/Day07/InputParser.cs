namespace QuestionSolutions.Day07;

public class InputParser
{

    private readonly Directory root = new("/");
    private Directory _currentDirectory { get; set; }

    private readonly string _lines;

    public InputParser(string lines)
    {
        _currentDirectory = root;
        _lines = lines;
    }

    public Directory ParseLines()
    {
        var lineParts = _lines.Split("\r\n").Skip(1);

        foreach (var line in lineParts)
        {
            ParseLine(line);
        }

        return root;
    }

    private void ParseLine(string line)
    {
        if (line.StartsWith("$"))
        {
            ParseCommand(line);
        }
        else if (line.StartsWith("dir"))
        {
            ParseDirectoryListing(line);
        }
        else
        {
            ParseFile(line);
        }
    }

    private void ParseDirectoryListing(string line)
    {
        var directoryName = line[4..];
        _currentDirectory.SubItems.Add(new Directory(directoryName)
        {
            ParentDirectory = _currentDirectory
        });
    }

    private void ParseCommand(string line)
    {
        var commandAndArgument = line[2..];
        if (commandAndArgument.StartsWith("cd"))
        {
            ParseDirectoryChange(commandAndArgument);
        }
        // $ ls does nothing meaningful, so we skip it
    }

    private void ParseDirectoryChange(string line)
    {
        var directoryName = line[3..];
        _currentDirectory = directoryName == ".."
            ? _currentDirectory.ParentDirectory
            : _currentDirectory.GetSubDirectory(directoryName);
    }

    private void ParseFile(string line)
    {
        var lineParts = line.Split(" ");
        var fileName = lineParts[1];
        var fileSize = int.Parse(lineParts[0]);
        _currentDirectory.SubItems.Add(new File(fileName, fileSize));
    }
}
