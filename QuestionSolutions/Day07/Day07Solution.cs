namespace QuestionSolutions.Day07;

public class Day07Solution
{
    private readonly Directory root = new("/");
    private Directory _currentDirectory { get; set; }

    public Day07Solution(string lines)
    {
        _currentDirectory = root;
        ParseLines(lines);
    }

    private void ParseLines(string lines)
    {
        var lineParts = lines.Split("\n").Skip(2);

        foreach (var line in lineParts)
        {
            var newItem = ParseLine(line);
            root.SubItems.Add(newItem);
        }
    }

    private static Item ParseLine(string line)
    {
        return LineToFile(line);
    }

    private static File LineToFile(string line)
    {
        var lineParts = line.Split(" ");
        var fileName = lineParts[1];
        var fileSize = int.Parse(lineParts[0]);
        return new File(fileName, fileSize);}

    public int GetSize()
    {
        return root.GetSize();
    }
}
