using System.Text.RegularExpressions;

namespace QuestionSolutions.Day05;

public partial record BasicMoveInstruction
{
    public int AmountToMove { get; }
    public int SourceStackNumber { get; }
    public int TargetStackNumber { get; }
    private int SourceStackIndex => SourceStackNumber - 1;
    private int TargetStackIndex => TargetStackNumber - 1;

    private static readonly Regex Parser = GeneratedParserRegex();
    
    public BasicMoveInstruction(string instructionDescription)
    {
        var match = Parser.Match(instructionDescription);

        AmountToMove = int.Parse(match.Groups[1].Value);
        SourceStackNumber = int.Parse(match.Groups[2].Value);
        TargetStackNumber = int.Parse(match.Groups[3].Value);
    }

    public void ApplyTo(List<Stack<char>> stacks)
    {
        for (var i = AmountToMove; i > 0; i--)
        {
            stacks[TargetStackIndex].Push(stacks[SourceStackIndex].Pop());
        }
    }

    [GeneratedRegex(@"move (?<amountToMove>\d+) from (?<sourceIndex>\d+) to (?<targetIndex>\d+)")]
    private static partial Regex GeneratedParserRegex();
}