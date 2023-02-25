using QuestionSolutions.Extensions;

namespace QuestionSolutions.Day08;

public class Day08Solution
{
    private readonly Tree[,] _forest;

    public Day08Solution(string input)
    {
        _forest = ParseInput(input);
    }

    private Tree[,] ParseInput(string input)
    {
        var lines = input.SplitOnNewLine();
        var lineLength = lines.First().Length;
        var result = new Tree[lineLength, lines.Length];

        for (var x = 0; x < lineLength; x++)
        {
            for (var y = 0; y < lines.Length; y++)
            {
                result[x, y] = new Tree(int.Parse(lines[y][x].ToString()), x, y);
            }
        }

        for (var x = 0; x < lineLength; x++)
        {
            for (var y = 0; y < lines.Length; y++)
            {
                var tree = result[x, y];
                tree.IsVisible = IsTreeVisible(tree, result);
            }
        }

        return result;
    }

    private bool IsTreeVisible(Tree tree, Tree[,] forest)
    {
        if (tree.X == 0 || tree.Y == 0 || tree.X == forest.GetLength(0) - 1 || tree.Y == forest.GetLength(1) - 1)
        {
            return true;
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

        return isVisibleFromLeft || isVisibleFromRight || isVisibleFromTop || isVisibleFromBottom;
    }

    public int CountVisibleTrees()
    {
        var result = 0;
        for (var x = 0; x < _forest.GetLength(0); x++)
        {
            for (var y = 0; y < _forest.GetLength(1); y++)
            {
                if (_forest[x, y].IsVisible)
                {
                    result++;
                }
            }
        }

        return result;
    }
}
