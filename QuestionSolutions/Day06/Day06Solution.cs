namespace QuestionSolutions.Day06;

public class Day06Solution
{
    public int FindStartOfPacketMarker(string input) => FindStartOfDistinctChars(input, 4);

    public int FindStartOfMessageMarker(string input) => FindStartOfDistinctChars(input, 14);

    private int FindStartOfDistinctChars(string input, int requiredLength)
    {
        var result = requiredLength;
        while (IsCharacterShared(input.Skip(result - requiredLength).Take(requiredLength).ToArray() ))
        {
            result++;
        }

        return result;
    }

    private bool IsCharacterShared(params char[] values)
    {
        var set = new HashSet<char>(values);

        return set.Count != values.Length;
    }
}
