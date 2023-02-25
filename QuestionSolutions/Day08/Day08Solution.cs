using QuestionSolutions.Extensions;

namespace QuestionSolutions.Day08;

public class Day08Solution
{
    private readonly Forest _forest;

    public Day08Solution(string input)
    {
        _forest = new Forest(new InputParser(input).Parse());
    }

    public int CountVisibleTrees() => _forest.Trees().Count(x => x.IsVisible);

    public int GetHighestScenicScore() => _forest.Trees().MaxBy(x => x.ScenicScore).ScenicScore;
}
