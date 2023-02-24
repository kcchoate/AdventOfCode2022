namespace QuestionSolutions.Day07;

public class Day07Solution
{
    private readonly Directory _root;

    public Day07Solution(string lines)
    {
        _root = new InputParser(lines).ParseLines();
    }

    public int GetSize()
    {
        return _root.GetSize();
    }
}
