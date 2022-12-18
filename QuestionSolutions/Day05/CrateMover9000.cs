namespace QuestionSolutions.Day05;

public class CrateMover9000
{
    private readonly List<Stack<char>> _stacks;
    private readonly Stack<BasicMoveInstruction> _moveInstructions = new();

    public CrateMover9000(List<Stack<char>> stacks, IEnumerable<string> moveInstructions)
    {
        _stacks = stacks;
        ParseInstructions(moveInstructions);
    }
    
    private void ParseInstructions(IEnumerable<string> input)
    {
        var instructionLines = input
            .Reverse()
            .TakeWhile(x => !string.IsNullOrWhiteSpace(x))
            .ToArray();

        foreach (var instruction in instructionLines)
        {
            _moveInstructions.Push(new BasicMoveInstruction(instruction));
        }
    }

    public void Work()
    {
        while (_moveInstructions.TryPop(out var instruction))
        {
            instruction.ApplyTo(_stacks);
        }
    }
}