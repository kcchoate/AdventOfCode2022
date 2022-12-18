using QuestionSolutions.Day05.MoveInstructions;

namespace QuestionSolutions.Day05.CrateMovers;

public class CrateMover9001 : CrateMover
{
    protected override Stack<MoveInstruction> _moveInstructions { get; } = new();
    
    public CrateMover9001(List<Stack<char>> stacks, IEnumerable<string> moveInstructions) : base(stacks)
    {
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
            _moveInstructions.Push(new BatchMoveInstruction(instruction));
        }
    }
}