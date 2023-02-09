namespace QuestionSolutions.Day06;

public class Day06Solution
{
    public int FindStartOfPacketMarker(string input)
    {
        var first = input[0];
        var second = input[1];
        var third = input[2];
        var fourth = input[3];
        var result = 4;

        while (IsCharacterShared(first, second, third, fourth))
        {
            result++;
            first = input[result - 4];
            second = input[result - 3];
            third = input[result - 2];
            fourth = input[result - 1];
        }

        return result;
    }

    public int FindStartOfMessageMarker(string input)
    {
        var result = 14;
        while (IsCharacterShared(input.Skip(result - 14).Take(14).ToArray() ))
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
