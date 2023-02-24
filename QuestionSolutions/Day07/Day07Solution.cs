namespace QuestionSolutions.Day07;

public class Day07Solution
{
    private readonly Directory _root;

    public Day07Solution(string lines)
    {
        _root = new InputParser(lines.TrimEnd('\r', '\n')).ParseLines();
    }

    public int Problem01Solution()
    {
        return _root.GetAllDirectories()
            .Where(x => x.GetSize() <= 100000)
            .Sum(x => x.GetSize());
    }

    public int Problem02Solution()
    {
        const int requiredSpace = 30_000_000;
        var freeSpace = 70_000_000 - _root.GetSize();
        var neededSpace = requiredSpace - freeSpace;
        return _root.GetAllDirectories()
            .Where(x => x.GetSize() > neededSpace)
            .OrderBy(x => x.GetSize())
            .First().GetSize();
    }

    public int GetSize()
    {
        return _root.GetSize();
    }
}
