using System.Text.RegularExpressions;

namespace QuestionSolutions.Day05.MoveInstructions;

public abstract partial record MoveInstruction
{
    public int AmountToMove { get; }
    public int SourceStackNumber { get; }
    public int TargetStackNumber { get; }
    protected int SourceStackIndex => SourceStackNumber - 1;
    protected int TargetStackIndex => TargetStackNumber - 1;
    
    private static readonly Regex Parser = GeneratedParserRegex();

    [GeneratedRegex(@"move (?<amountToMove>\d+) from (?<sourceIndex>\d+) to (?<targetIndex>\d+)")]
    private static partial Regex GeneratedParserRegex();
    
    protected MoveInstruction(string instructionDescription)
    {
        var match = Parser.Match(instructionDescription);

        AmountToMove = int.Parse(match.Groups[1].Value);
        SourceStackNumber = int.Parse(match.Groups[2].Value);
        TargetStackNumber = int.Parse(match.Groups[3].Value);
    }

    public abstract void ApplyTo(List<Stack<char>> stacks);
}