using System.Text.RegularExpressions;

namespace QuestionSolutions.Day05.MoveInstructions;

public record BasicMoveInstruction : MoveInstruction
{
    public BasicMoveInstruction(string instructionDescription) : base(instructionDescription)
    {
    }

    public override void ApplyTo(List<Stack<char>> stacks)
    {
        for (var i = AmountToMove; i > 0; i--)
        {
            stacks[TargetStackIndex].Push(stacks[SourceStackIndex].Pop());
        }
    }
}