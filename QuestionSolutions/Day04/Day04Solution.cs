using QuestionSolutions.Extensions;

namespace QuestionSolutions.Day04;

public class Day04Solution
{
    public int CalculateTotalOverlaps(string[] input)
    {
        return input
            .Select(ParsePair)
            .Count(IsTotallyOverlapped);
    }

    public int CalculatePartialOverlaps(string[] input)
    {
        return input.Select(ParsePair)
            .Count(IsPartiallyOverlapped);
    }

    private static bool IsTotallyOverlapped((Range first, Range second) pair) =>
        pair.first.Contains(pair.second) || pair.second.Contains(pair.first);

    private static bool IsPartiallyOverlapped((Range first, Range second) pair) => pair.first.Overlaps(pair.second);

    private static (Range first, Range second) ParsePair(string input)
    {
        var split = input.Split(',');
        return (ParseRange(split[0]), ParseRange(split[1]));
    }

    private static Range ParseRange(string range)
    {
        var split = range.Split('-');
        return new Range(int.Parse(split[0]), int.Parse(split[1]));
    }
}