namespace QuestionSolutions.Day08;

public class Forest
{
    private readonly Tree[,] _forest;

    public Forest(Tree[,] forest)
    {
        _forest = forest;
    }

    public IEnumerable<Tree> Trees()
    {
        for (var x = 0; x < _forest.GetLength(0); x++)
        {
            for (var y = 0; y < _forest.GetLength(1); y++)
            {
                yield return _forest[x, y];
            }
        }
    }
}
