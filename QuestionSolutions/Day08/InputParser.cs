using QuestionSolutions.Extensions;

namespace QuestionSolutions.Day08;

public class InputParser
{
    private readonly string[] _lines;

    public InputParser(string input)
    {
        _lines = input.SplitOnNewLine();
    }

    public Tree[,] Parse()
    {
        var lineLength = _lines.First().Length;
        var result = new Tree[lineLength, _lines.Length];

        for (var x = 0; x < lineLength; x++)
        {
            for (var y = 0; y < _lines.Length; y++)
            {
                result[x, y] = new Tree(int.Parse(_lines[y][x].ToString()), x, y);
            }
        }

        for (var x = 0; x < lineLength; x++)
        {
            for (var y = 0; y < _lines.Length; y++)
            {
                var tree = result[x, y];
                CalculateTreeProperties(tree, result);
            }
        }

        return result;
    }

    private static void CalculateTreeProperties(Tree tree, Tree[,] forest)
    {
        if (tree.X == 0 || tree.Y == 0 || tree.X == forest.GetLength(0) - 1 || tree.Y == forest.GetLength(1) - 1)
        {
            tree.IsVisible = true;
            return;
        }

        var isVisibleFromLeft = true;
        var isVisibleFromRight = true;
        var isVisibleFromTop = true;
        var isVisibleFromBottom = true;

        for (var rowIndex = 0; rowIndex < tree.X; rowIndex++)
        {
            var rowNeighbor = forest[rowIndex, tree.Y];
            if (rowNeighbor.Height >= tree.Height)
            {
                isVisibleFromLeft = false;
            }
        }

        for (var rowIndex = forest.GetLength(0) -1; rowIndex > tree.X; rowIndex--)
        {
            var rowNeighbor = forest[rowIndex, tree.Y];
            if (rowNeighbor.Height >= tree.Height)
            {
                isVisibleFromRight = false;
            }
        }

        for (var columnIndex = 0; columnIndex < tree.Y; columnIndex++)
        {
            var columnNeighbor = forest[tree.X, columnIndex];
            if (columnNeighbor.Height >= tree.Height)
            {
                isVisibleFromTop = false;
            }
        }

        for (var columnIndex = forest.GetLength(1) - 1; columnIndex > tree.Y; columnIndex--)
        {
            var columnNeighbor = forest[tree.X, columnIndex];
            if (columnNeighbor.Height >= tree.Height)
            {
                isVisibleFromBottom = false;
            }
        }

        tree.IsVisible = isVisibleFromLeft || isVisibleFromRight || isVisibleFromTop || isVisibleFromBottom;
    }
}
