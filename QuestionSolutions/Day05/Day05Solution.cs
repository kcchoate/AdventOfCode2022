using QuestionSolutions.Day05.CrateMovers;

namespace QuestionSolutions.Day05;

public class Day05Solution
{
    private readonly string[] _input;
    private readonly List<Stack<char>> _stacks = new();

    public Day05Solution(string[] input)
    {
        _input = input;
        ParseStacks(input);
    }
    
    public string PerformWorkWithCrateMover9000()
    {
        var crateMover9000 = new CrateMover9000(_stacks, _input);
        crateMover9000.Work();
        return new string(_stacks.Select(x => x.TryPeek(out var val) ? val : ' ').ToArray());
    }

    public string PerformWorkWithCrateMover9001()
    {
        var crateMover9000 = new CrateMover9001(_stacks, _input);
        crateMover9000.Work();
        return new string(_stacks.Select(x => x.TryPeek(out var val) ? val : ' ').ToArray());
    }

    private void ParseStacks(IEnumerable<string> input)
    {
        var stackLines = input
            .TakeWhile(x => !string.IsNullOrWhiteSpace(x))
            .Reverse()
            .Skip(1)
            .ToArray();

        CreateStacks(stackLines);

        foreach (var stackLine in stackLines)
        {
            AddStackLineToStacks(stackLine);
        }
    }

    private void AddStackLineToStacks(string stackLine)
    {
        var stackContents = stackLine.Chunk(4).ToList();
        for (var i = 0; i < stackContents.Count; i++)
        {
            var stackContent = stackContents[i][1];
            var stack = _stacks[i];
            if (stackContent != ' ')
            {
                stack.Push(stackContent);
            }
        }
    }

    private void CreateStacks(IEnumerable<string> stackLines)
    {
        var numberOfStacks = (stackLines.First().Length + 1) / 4;
        for (var i = 0; i < numberOfStacks; i++)
        {
            _stacks.Add(new Stack<char>());
        }
    }
}