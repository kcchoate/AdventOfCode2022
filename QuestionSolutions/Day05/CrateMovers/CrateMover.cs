using QuestionSolutions.Day05.MoveInstructions;

namespace QuestionSolutions.Day05.CrateMovers;

public abstract class CrateMover
{
    private readonly List<Stack<char>> _stacks;
    protected abstract Stack<MoveInstruction> _moveInstructions { get; }

    protected CrateMover(List<Stack<char>> stacks)
    {
        _stacks = stacks;
    }
    

    public void Work()
    {
        while (_moveInstructions.TryPop(out var instruction))
        {
            instruction.ApplyTo(_stacks);
        }
    }
}