namespace QuestionSolutions.Day06;

public class Day06Solution
{
    public int FindStartOfPacketMarker(string input) => FindStartOfDistinctChars(input, 4);

    public int FindStartOfMessageMarker(string input) => FindStartOfDistinctChars(input, 14);

    private int FindStartOfDistinctChars(string input, int requiredLength)
    {
        var result = requiredLength;

        while (true)
        {
            var listOfChars = input.Skip(result - requiredLength).Take(requiredLength).ToArray();
            if (!IsCharacterShared(listOfChars))
            {
                return result;
            }

            result += FindIndexOfFirstSharedChar(listOfChars) + 1;
        }
    }

    private bool IsCharacterShared(params char[] values)
    {
        var set = new HashSet<char>(values);

        return set.Count != values.Length;
    }

    private int FindIndexOfFirstSharedChar(char[] values)
    {
        var lookup = new Dictionary<char, int>();
        for (var i = 0; i < values.Length; i++)
        {
            var value = values[i];
            if (lookup.TryGetValue(value, out var idx))
            {
                return idx;
            }

            lookup[value] = i;
        }

        return values.Length - 1;
    }
}
