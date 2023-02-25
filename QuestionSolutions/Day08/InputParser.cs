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
        var isVisibleFromLeft = true;
        var isVisibleFromRight = true;
        var isVisibleFromTop = true;
        var isVisibleFromBottom = true;

        var scenicLeft = 0;
        var scenicRight = 0;
        var scenicUp = 0;
        var scenicDown = 0;

        for (var rowIndex = tree.X - 1; rowIndex >= 0; rowIndex--)
        {
            scenicLeft++;

            var rowNeighbor = forest[rowIndex, tree.Y];
            if (rowNeighbor.Height >= tree.Height)
            {
                isVisibleFromLeft = false;
                break;
            }
        }

        for (var rowIndex = tree.X + 1; rowIndex < forest.GetLength(0); rowIndex++)
        {
            scenicRight++;

            var rowNeighbor = forest[rowIndex, tree.Y];
            if (rowNeighbor.Height >= tree.Height)
            {
                isVisibleFromRight = false;
                break;
            }

        }

        for (var columnIndex = tree.Y - 1; columnIndex >= 0; columnIndex--)
        {
            scenicUp++;

            var columnNeighbor = forest[tree.X, columnIndex];
            if (columnNeighbor.Height >= tree.Height)
            {
                isVisibleFromTop = false;
                break;
            }
        }

        for (var columnIndex = tree.Y + 1; columnIndex < forest.GetLength(1); columnIndex++)
        {
            scenicDown++;

            var columnNeighbor = forest[tree.X, columnIndex];
            if (columnNeighbor.Height >= tree.Height)
            {
                isVisibleFromBottom = false;
                break;
            }
        }

        tree.IsVisible = isVisibleFromLeft || isVisibleFromRight || isVisibleFromTop || isVisibleFromBottom;
        tree.ScenicScore = scenicLeft * scenicRight * scenicUp * scenicDown;
    }
}
