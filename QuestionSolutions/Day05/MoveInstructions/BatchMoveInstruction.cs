using System.Text.RegularExpressions;

namespace QuestionSolutions.Day05.MoveInstructions;

public record BatchMoveInstruction : MoveInstruction
{
    public BatchMoveInstruction(string instructionDescription) : base(instructionDescription)
    {
    }

    public override void ApplyTo(List<Stack<char>> stacks)
    {
        var tempStack = new Stack<char>();
        for (var i = 0; i < AmountToMove; i++)
        {
            tempStack.Push(stacks[SourceStackIndex].Pop());
        }
        for (var i = 0; i < AmountToMove; i++)
        {
            stacks[TargetStackIndex].Push(tempStack.Pop());
        }
    }
}