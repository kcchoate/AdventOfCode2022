using QuestionSolutions.Extensions;

namespace QuestionSolutions.Day08;

public class Day08Solution
{
    private readonly Tree[,] _forest;

    public Day08Solution(string input)
    {
        _forest = new InputParser(input).Parse();
    }

    public int CountVisibleTrees()
    {
        var result = 0;
        ProcessForest(tree =>
        {
            if (tree.IsVisible)
            {
                result++;
            }
        });

        return result;
    }

    private void ProcessForest(Action<Tree> processor)
    {
        for (var x = 0; x < _forest.GetLength(0); x++)
        {
            for (var y = 0; y < _forest.GetLength(1); y++)
            {
                var tree = _forest[x, y];
                processor.Invoke(tree);
            }
        }
    }
}
