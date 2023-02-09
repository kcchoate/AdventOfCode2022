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

    private bool IsCharacterShared(char first, char second, char third, char fourth)
    {
        var set = new HashSet<char>
        {
            first,
            second,
            third,
            fourth
        };

        return set.Count != 4;
    }
}
